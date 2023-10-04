using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class TrainerSalon : BaseEntity
    {
        public int IdPersonaFk { get; set; }
        public Persona Personas { get; set; }
        public int IdSalonFk { get; set; }
        public Salon Salones { get; set; }

    }
}