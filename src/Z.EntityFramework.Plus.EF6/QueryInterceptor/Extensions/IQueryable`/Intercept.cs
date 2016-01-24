﻿// Description: EF Bulk Operations & Utilities | Bulk Insert, Update, Delete, Merge from database.
// Website & Documentation: https://github.com/zzzprojects/Entity-Framework-Plus
// Forum: https://github.com/zzzprojects/EntityFramework-Plus/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System.Linq;
using System.Linq.Expressions;

namespace Z.EntityFramework.Plus
{
    public static class QueryInterceptorQueryableExtensions
    {
        public static IQueryable<T> InterceptWith<T>(this IQueryable<T> query, params ExpressionVisitor[] visitors)
        {
            return new QueryInterceptorQueryable<T>(query, visitors);
        }
    }
}