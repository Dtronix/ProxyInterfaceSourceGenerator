//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by https://github.com/StefH/ProxyInterfaceSourceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------

#nullable enable
using System;

namespace ProxyInterfaceSourceGeneratorTests.Source
{
    public partial class GenericProxy<T> : IGeneric<T>
    {
        public ProxyInterfaceSourceGeneratorTests.Source.Generic<T> _Instance { get; }
        



        public T Test(T value)
        {
            T value_ = value;
            var result__1701808026 = _Instance.Test(value_);
            return result__1701808026;
        }





        public GenericProxy(ProxyInterfaceSourceGeneratorTests.Source.Generic<T> instance)
        {
            _Instance = instance;
            


        }
    }
}
#nullable disable