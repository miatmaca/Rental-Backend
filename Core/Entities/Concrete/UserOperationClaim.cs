﻿using Core.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Entity
{
  public  class UserOperationClaim:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimsId { get; set; }
    }
}
