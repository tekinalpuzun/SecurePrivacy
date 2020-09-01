using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using SecurePrivacy.Common.Models;
using SecurePrivacy.Domain;
using SecurePrivacy.Domain.Dto;

namespace SecurePrivacy.Common
{
    public class BookProfile: Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<BookDto, Book>();
            CreateMap<BookModel, BookDto>();
            CreateMap<BookDto, BookModel>();
        }
    }
}
