﻿namespace HappyMe.Web.Areas.Administration.InputModels.Users
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    using HappyMe.Common.Mapping;
    using HappyMe.Data.Models;
    using HappyMe.Web.Common.Attributes;

    public class UserUpdateInputModel : IMapFrom<User>, IMapTo<User>
    {
        [HiddenInput(DisplayValue = false)]
        public string Id { get; set; }

        [Required]
        [PlaceHolder("Потребителско име")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [PlaceHolder("Имейл")]
        public string Email { get; set; }
    }
}