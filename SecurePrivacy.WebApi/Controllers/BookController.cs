using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SecurePrivacy.Common.Models;
using SecurePrivacy.Domain.Dto;
using SecurePrivacy.Service.Contracts;

namespace SecurePrivacy.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;

        public BookController(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        // GET api/values
        
        [HttpGet]
        public BookModel Get(string id)
        {
            return _mapper.Map<BookModel>(_bookService.Read(id));
        }


        // POST api/values
        [HttpPost]
        public BookModel Post([FromBody]BookModel model)
        {
            var result = _bookService.GetAuthorization(model.AccessKey);
            if (!result)
                return null;
            return _mapper.Map<BookModel>(_bookService.Create(_mapper.Map<BookDto>(model)));
        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody]BookModel model, string id)
        {
            var result = _bookService.GetAuthorization(model.AccessKey);
            if (result)
                _bookService.Update(id, _mapper.Map<BookDto>(model));
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete(string id)
        {
            _bookService.Delete(id);
        }
    }
}