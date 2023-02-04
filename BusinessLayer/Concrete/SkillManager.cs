﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;
        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void TAdd(Skill t)
        {
            _skillDal.insert(t);
        }

        public void TDelete(Skill t)
        {
            _skillDal.delete(t);
        }

        public Skill TGetById(int id)
        {
            return _skillDal.GetById(id);
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetAll();
        }

        public void TUpdate(Skill t)
        {
            _skillDal.update(t);
        }
    }
}
