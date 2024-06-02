using AutoMapper.Configuration.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BasicLobrary.Entites
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        //Relationship: One To Many
        [JsonIgnore]
        public List<Employee> Employees { get; set; }
    }
}
