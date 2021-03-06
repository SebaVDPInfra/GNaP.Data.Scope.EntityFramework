﻿/*
 * Copyright (C) 2014 Mehdi El Gueddari
 * http://mehdi.me
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 */

namespace GNaP.Data.Scope.EntityFramework.Implementation
{
    using System.Data.Entity;
    using Interfaces;

    public class EntityFrameworkAmbientLocator : IAmbientDbLocator
    {
        public TDbContext Get<TDbContext>() where TDbContext : DbContext
        {
            var ambientDbContextScope = EntityFrameworkScope.GetAmbientScope();
            return ambientDbContextScope == null ? null : ambientDbContextScope.Get<TDbContext>();
        }
    }
}
