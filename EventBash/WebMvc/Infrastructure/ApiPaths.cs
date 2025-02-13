﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.Infrastructure
{
    public class ApiPaths
    {
        //creating subclasses to talk to each microservices
        public static class Events //events catalog
        {
            public static string GetAllCategories(string baseUri)   //plan to give you a url to get the API, baseUri is as parameter passedf rom docker
            {
                return $"{baseUri}EventCategories"; //baseUri here would be http:/\/\localhost:61290/api/events/
            }

            public static string GetAllVenues(string baseUri)
            {
                return $"{baseUri}EventVenue"; //selvi - updated Event Venue to Eventvenues
            }

            public static string GetAllEventItems(string baseUri, int page, int size,
                int? category, int? venue ) //you have to pass page and size. But brand andtype are nullable value types.
            {
                var filterQs = string.Empty;

                if(venue.HasValue || category.HasValue)
                {
                    var categoryQs = (category.HasValue) ? category.Value.ToString() : "null";
                    var venueQs = (venue.HasValue) ? venue.Value.ToString() : "null";

                    filterQs = $"/category/{categoryQs}/venue/{venueQs}";
                }

                return $"{baseUri}items{filterQs}?pageSize={size}&pageIndex={page}";  //Need to implement brand and type
            }

        }
        public static class Order
        {
            public static string GetOrder(string baseUri, string orderId)
            {
                return $"{baseUri}/{orderId}";
            }

            //public static string GetOrdersByUser(string baseUri, string userName)
            //{
            //    return $"{baseUri}/userOrders?userName={userName}";
            //}
            public static string GetOrders(string baseUri)
            {
                return baseUri;
            }
            public static string AddNewOrder(string baseUri)
            {
                return $"{baseUri}/new";
            }
        }
        public static class Basket
        {
            public static string GetBasket(string baseUri, string basketId)
            {
                return $"{baseUri}/{basketId}";
            }

            public static string UpdateBasket(string baseUri)
            {
                return baseUri;
            }

            public static string CleanBasket(string baseUri, string basketId)
            {
                return $"{baseUri}/{basketId}";
            }
        }

    }
}
