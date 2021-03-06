﻿using AutoMapper;
using Products.BL.Models;
using Products.EDM;
using System.Linq;

namespace Products.BL.Mapping
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Categories

            CreateMap<Category, CategoryModel>();
            //CreateMap<Category, CategoryGridModel>();

            #endregion

            #region Products
            CreateMap<AddProductModel, Product>();
            CreateMap<ProductGridModel, Product>();

            CreateMap<Product, ProductComboModel>();

            CreateMap<Product, ProductGridModel>()
                .ForMember(d => d.CategoryName, o => o.MapFrom(s => s.Category.Name));

            #endregion

            #region Customers

            CreateMap<Customer, CustomerComboModel>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name));

            CreateMap<Customer, CustomerGridModel>()
                .ForMember(d => d.Charge, o => o.MapFrom(s =>
                    s.Sales.Sum(p =>
                        p.SaleDetails.Sum(sd =>
                            (sd.Qte - sd.ReturnedQte) * sd.ProductSell * sd.Discount))
                    - s.Sales.Sum(p =>
                        p.SalePayments.Sum(sp => sp.Paid))));

            #endregion

            #region Suppliers

            CreateMap<AddSupplierModel, Supplier>();
            CreateMap<Supplier, SupplierGridModel>();

            #endregion

            #region Sale

            //CreateMap<Sale, SaleModel>()

            //    //.ForMember(d => d.Charge, o => o.MapFrom(s => s.SaleDetail.Sum - s.SalePayments.Sum(p => p.Paid)))
            //    .ForMember(d => d.Paid, o => o.MapFrom(s => s.SalePayments.Sum(p => p.Paid)));

            CreateMap<Sale, SaleGridModel>();

            CreateMap<Sale, SaleReportModel>()
                .ForMember(d => d.CustomerName, o => o.MapFrom(s => s.Customer.Name))
                .ForMember(d => d.CustomerPhone, o => o.MapFrom(s => s.Customer.Phone))
                .ForMember(d => d.Discount, o => o.MapFrom(s => s.Discount / 100))
                .ForMember(d => d.SaleDetails, o => o.MapFrom(s => s.SaleDetails));

            #endregion

            #region Sale details

            CreateMap<AddSaleDetailGridModel, SaleDetail>()
                .ForMember(d => d.ReturnedQte, o => o.MapFrom(s => 0));

            CreateMap<SaleDetail, SaleDetailModel>()
                .ForMember(d => d.ProductName, o => o.MapFrom(s => s.Product.Name));

            CreateMap<SaleDetail, SaleDetailGridModel>()
                .ForMember(d => d.ProductName, o => o.MapFrom(s => s.Product.Name));


            CreateMap<SaleDetail, SaleDetailReportModel>()
                .ForMember(d => d.Discount, o => o.MapFrom(s => s.Discount / 100));

            CreateMap<SaleDetail, ProductReturnModel>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Product.Name))
                .ForMember(d => d.Qte, o => o.MapFrom(s => s.Qte - s.ReturnedQte));


            #endregion
        }
    }
}
