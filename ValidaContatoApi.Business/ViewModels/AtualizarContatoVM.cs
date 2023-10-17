﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidaContatoApi.Domain.Enum;

namespace ValidaContatoApi.Business.ViewModels
{
    public class AtualizarContatoVM
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public SexoEnum Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
