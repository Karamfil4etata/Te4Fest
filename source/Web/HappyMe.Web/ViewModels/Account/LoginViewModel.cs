﻿namespace HappyMe.Web.ViewModels.Account
{
    using System.ComponentModel.DataAnnotations;

    using Resource = Resources.Account.ViewModels.LoginViewModel;
    using ResourceCommon = Resources.Account.AccountCommon;

    public class LoginViewModel
    {
        [Required(
            ErrorMessageResourceName = "Required_field_error_generic",
            ErrorMessageResourceType = typeof(ResourceCommon))]
        [Display(Name = "Username", ResourceType = typeof(ResourceCommon))]
        public string Username { get; set; }

        [Required(
            ErrorMessageResourceName = "Required_field_error_generic",
            ErrorMessageResourceType = typeof(ResourceCommon))]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(ResourceCommon))]
        public string Password { get; set; }

        [Display(Name = "Remember_me", ResourceType = typeof(Resource))]
        public bool RememberMe { get; set; }
    }
}