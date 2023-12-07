using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using registration.model;

namespace registration.Repository.Interface
{
    public interface IProfileRepository
    {
        Profile Create (Profile obj);
    }
}