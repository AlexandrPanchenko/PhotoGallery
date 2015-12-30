﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginExample.Models
{
   
        public class PagingInfo
        {
            public int TotalItems { get; set; }

            // Кол-во на одной странице
            public int ItemsPerPage { get; set; }

            // Номер текущей страницы
            public int CurrentPage { get; set; }

            // Общее кол-во страниц
            public int TotalPages
            {
                get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
            }
        }
    }

