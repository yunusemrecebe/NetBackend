﻿using Core.Utilities.Results;
using Core.Utilities.Security.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRefreshTokenService
    {
        IDataResult<RefreshToken> GetByUserId(int id);
        IResult Add(RefreshToken refreshToken);
        IResult Update(RefreshToken refreshToken);
    }
}
