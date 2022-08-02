﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDistrictService:IGenericService<District>
    {
        List<District> GetCityDistricts(int id);
    }
}
