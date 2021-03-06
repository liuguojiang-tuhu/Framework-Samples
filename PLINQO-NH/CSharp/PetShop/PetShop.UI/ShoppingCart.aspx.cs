﻿using System;
using System.Web.UI;
using PetShop.Core.Utility;
using Petshop.Data;
using Petshop.Data.Entities;

namespace PetShop.UI
{
    public partial class ShoppingCart : Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string itemId = Request.QueryString["addItem"];
                if (!string.IsNullOrEmpty(itemId))
                {
                    using (var context = new PetshopDataContext())
                    {
                        var profile = context.Profile.GetProfile(Page.User.Identity.Name);
                        if (profile != null  && !string.IsNullOrEmpty(profile.Username))
                        {
                            CartHelper.Add(profile.ShoppingCart, itemId, profile.UniqueID, true);
                        }
                    }
                    // Redirect to prevent duplictations in the cart if user hits "Refresh"
                    Response.Redirect("~/ShoppingCart.aspx", true);
                }
            }
        }
    }
}