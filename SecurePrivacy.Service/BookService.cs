using SecurePrivacy.Domain.Dto;
using SecurePrivacy.Repository.Contracts;
using SecurePrivacy.Service.Contracts;
using System;
using AutoMapper;
using SecurePrivacy.Domain;

namespace SecurePrivacy.Service
{
    public class BookService : IBookService
    {
        private IBookRepository _bookRepository;
        private IMapper _mapper;

        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public BookDto Create(BookDto book)
        {
            Book obj = _mapper.Map<Book>(book);
            return _mapper.Map<BookDto>(_bookRepository.Create(obj));
        }

        public void Update(string id, BookDto book)
        {
            Book obj = _mapper.Map<Book>(book);
            _bookRepository.Update(id, obj);
        }

        public BookDto Read(string id)
        {
            return _mapper.Map<BookDto>(_bookRepository.GetById(id));
        }

        public void Delete(string id)
        {
            _bookRepository.Delete(id);
        }

        public bool GetAuthorization(Guid key)
        {
            return _bookRepository.CheckTheAuthorization(key);
        }
    }
}
