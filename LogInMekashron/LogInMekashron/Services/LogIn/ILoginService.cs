﻿using System.Threading.Tasks;
using System.Xml.Linq;

namespace LogInMekashron.LogIn
{
    interface ILoginService
    {
        Task<XDocument> Login(string login, string password);
    }
}

