﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_GUI.Helper
{
    public class ApiRoutes
    {
        public const string Base = "api";

        public static class Account
        {
            public const string signup = Base + "/Account/SignUp";
            public const string signin = Base + "/Account/SignIn";
            public const string getCurrentBalance = Base + "/Account/GetCurrentBalance/ID={id}";
            public const string makePayment = Base + "/Account/MakePayment";
            public const string rechargeAccount = Base + "/Account/RechargeAccount";
        }

        public static class Product
        {
            public const string getTopSellingProductId = Base + "/Product/GetTopSellingProductId";
            public const string getAllProductId = Base + "/Product/GetAllProductId";
            public const string getProductDisplay = Base + "/Product/GetProductDisplay/ID={id}";
            public const string getProductDetail = Base + "/Product/GetProductDetail/ID={id}";
            public const string getProductImg = Base + "/Product/GetProductImg/ID={id}";
            public const string getProductReview = Base + "/Product/GetProductReview/ID={id}";
            public const string getProductSearchList = Base + "/Product/GetProductSearchList/Search={search}";
            public const string createProductImage = Base + "/Product/CreateProductImage"; 
        }

        public static class Shop
        {
            public const string getShop = Base + "/Shop/GetShop/Id={id}";
            public const string createShop = Base + "/Shop/CreateShop";
            public const string createProduct = Base + "/Shop/CreateProduct";
            public const string getShopProductId = Base + "/Shop/GetShopProductId/Id={id}";
            public const string updateProductInfo = Base + "/Shop/UpdateProductInfo";
        }

        public static class Cart
        {
            public const string CheckCartQuantity = Base + "/Cart/CheckCartQuantity/UserId={userId}/ProductId={productId}/Quantity={quantity}";
            public const string InsertCart = Base + "/Cart/InsertCart";
            public const string DeleteCart = Base + "/Cart/DeleteCart";
            public const string ClearCart = Base + "/Cart/ClearCart";
            public const string GetCart = Base + "/Cart/GetCart/UserId={userId}";
        }

        public static class Order
        {
            public const string createOrder = Base + "/Order/CreateOrder";
            public const string createOrderDetail = Base + "/Order/CreateOrderDetail";
            public const string getOrder = Base + "/Order/GetOrder/UserId={id}";
            public const string getOrderDetail = Base + "/Order/GetOrderDetail/OrderId={id}";
        }

        public static class File
        {
            public const string postImage = Base + "/File/UploadClientImage";
            public const string getImage = Base + "/File/ClientImage/Name={name}"; 
        }

        public static class Transport
        {
            public const string getShippingLog = Base + "/Transport/GetShippingLog/OrderId={id}";
        }

        public class Utility
        {
            public static string makeCheckCartURL(Library.Models.Cart value) {
                string result = Base + "/Cart/CheckCartQuantity/UserId={userId}/ProductId={productId}/Quantity={quantity}";
                result = result.Replace("{userId}", value.UserId);
                result = result.Replace("{productId}", value.ProductId);
                result = result.Replace("{quantity}", value.Quantity.ToString());
                return result;
            }
        }
    }
}
