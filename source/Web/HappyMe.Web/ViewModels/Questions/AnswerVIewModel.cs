﻿namespace HappyMe.Web.ViewModels.Questions
{
    using AutoMapper;

    using HappyMe.Common.Mapping;
    using HappyMe.Data.Models;

    public class AnswerViewModel : IMapFrom<Answer>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public byte[] ImageData { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Answer, AnswerViewModel>()
                .ForMember(m => m.ImageData, opt => opt.MapFrom(e => e.Image.ImageData));
        }
    }
}