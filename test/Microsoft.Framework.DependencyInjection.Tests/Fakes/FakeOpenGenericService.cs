// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Framework.DependencyInjection.Tests.Fakes
{
    public class FakeOpenGenericService<T> : IFakeOpenGenericService<T>
    {
        private readonly T _otherService;

        public FakeOpenGenericService(T otherService)
        {
            _otherService = otherService;
        }

        public T SimpleMethod()
        {
            return _otherService;
        }
    }
}
