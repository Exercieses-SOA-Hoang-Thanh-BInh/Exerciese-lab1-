﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Country", Namespace="http://tempuri.org/")]
    public partial class Country : object
    {
        
        private string CodeField;
        
        private string NameField;
        
        private string ContinentField;
        
        private string RegionField;
        
        private int PopulationField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Continent
        {
            get
            {
                return this.ContinentField;
            }
            set
            {
                this.ContinentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Region
        {
            get
            {
                return this.RegionField;
            }
            set
            {
                this.RegionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int Population
        {
            get
            {
                return this.PopulationField;
            }
            set
            {
                this.PopulationField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="City", Namespace="http://tempuri.org/")]
    public partial class City : object
    {
        
        private int IDField;
        
        private string NameField;
        
        private string CountryCodeField;
        
        private string DistrictField;
        
        private int PopulationField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ID
        {
            get
            {
                return this.IDField;
            }
            set
            {
                this.IDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string CountryCode
        {
            get
            {
                return this.CountryCodeField;
            }
            set
            {
                this.CountryCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string District
        {
            get
            {
                return this.DistrictField;
            }
            set
            {
                this.DistrictField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int Population
        {
            get
            {
                return this.PopulationField;
            }
            set
            {
                this.PopulationField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllCountries", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.GetAllCountriesResponse> GetAllCountriesAsync(ServiceReference1.GetAllCountriesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCountryByCode", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.GetCountryByCodeResponse> GetCountryByCodeAsync(ServiceReference1.GetCountryByCodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCityByName", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.GetCityByNameResponse> GetCityByNameAsync(ServiceReference1.GetCityByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllCitiesByCountryCode", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.GetAllCitiesByCountryCodeResponse> GetAllCitiesByCountryCodeAsync(ServiceReference1.GetAllCitiesByCountryCodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCitiesByDistrict", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.GetCitiesByDistrictResponse> GetCitiesByDistrictAsync(ServiceReference1.GetCitiesByDistrictRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllCountriesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllCountries", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetAllCountriesRequestBody Body;
        
        public GetAllCountriesRequest()
        {
        }
        
        public GetAllCountriesRequest(ServiceReference1.GetAllCountriesRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllCountriesRequestBody
    {
        
        public GetAllCountriesRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllCountriesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllCountriesResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetAllCountriesResponseBody Body;
        
        public GetAllCountriesResponse()
        {
        }
        
        public GetAllCountriesResponse(ServiceReference1.GetAllCountriesResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllCountriesResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceReference1.Country[] GetAllCountriesResult;
        
        public GetAllCountriesResponseBody()
        {
        }
        
        public GetAllCountriesResponseBody(ServiceReference1.Country[] GetAllCountriesResult)
        {
            this.GetAllCountriesResult = GetAllCountriesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCountryByCodeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCountryByCode", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetCountryByCodeRequestBody Body;
        
        public GetCountryByCodeRequest()
        {
        }
        
        public GetCountryByCodeRequest(ServiceReference1.GetCountryByCodeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCountryByCodeRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string code;
        
        public GetCountryByCodeRequestBody()
        {
        }
        
        public GetCountryByCodeRequestBody(string code)
        {
            this.code = code;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCountryByCodeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCountryByCodeResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetCountryByCodeResponseBody Body;
        
        public GetCountryByCodeResponse()
        {
        }
        
        public GetCountryByCodeResponse(ServiceReference1.GetCountryByCodeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCountryByCodeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceReference1.Country GetCountryByCodeResult;
        
        public GetCountryByCodeResponseBody()
        {
        }
        
        public GetCountryByCodeResponseBody(ServiceReference1.Country GetCountryByCodeResult)
        {
            this.GetCountryByCodeResult = GetCountryByCodeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCityByNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCityByName", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetCityByNameRequestBody Body;
        
        public GetCityByNameRequest()
        {
        }
        
        public GetCityByNameRequest(ServiceReference1.GetCityByNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCityByNameRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public GetCityByNameRequestBody()
        {
        }
        
        public GetCityByNameRequestBody(string name)
        {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCityByNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCityByNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetCityByNameResponseBody Body;
        
        public GetCityByNameResponse()
        {
        }
        
        public GetCityByNameResponse(ServiceReference1.GetCityByNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCityByNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceReference1.City GetCityByNameResult;
        
        public GetCityByNameResponseBody()
        {
        }
        
        public GetCityByNameResponseBody(ServiceReference1.City GetCityByNameResult)
        {
            this.GetCityByNameResult = GetCityByNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllCitiesByCountryCodeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllCitiesByCountryCode", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetAllCitiesByCountryCodeRequestBody Body;
        
        public GetAllCitiesByCountryCodeRequest()
        {
        }
        
        public GetAllCitiesByCountryCodeRequest(ServiceReference1.GetAllCitiesByCountryCodeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllCitiesByCountryCodeRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string countryCode;
        
        public GetAllCitiesByCountryCodeRequestBody()
        {
        }
        
        public GetAllCitiesByCountryCodeRequestBody(string countryCode)
        {
            this.countryCode = countryCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllCitiesByCountryCodeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllCitiesByCountryCodeResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetAllCitiesByCountryCodeResponseBody Body;
        
        public GetAllCitiesByCountryCodeResponse()
        {
        }
        
        public GetAllCitiesByCountryCodeResponse(ServiceReference1.GetAllCitiesByCountryCodeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllCitiesByCountryCodeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceReference1.City[] GetAllCitiesByCountryCodeResult;
        
        public GetAllCitiesByCountryCodeResponseBody()
        {
        }
        
        public GetAllCitiesByCountryCodeResponseBody(ServiceReference1.City[] GetAllCitiesByCountryCodeResult)
        {
            this.GetAllCitiesByCountryCodeResult = GetAllCitiesByCountryCodeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCitiesByDistrictRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCitiesByDistrict", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetCitiesByDistrictRequestBody Body;
        
        public GetCitiesByDistrictRequest()
        {
        }
        
        public GetCitiesByDistrictRequest(ServiceReference1.GetCitiesByDistrictRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCitiesByDistrictRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string district;
        
        public GetCitiesByDistrictRequestBody()
        {
        }
        
        public GetCitiesByDistrictRequestBody(string district)
        {
            this.district = district;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCitiesByDistrictResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCitiesByDistrictResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetCitiesByDistrictResponseBody Body;
        
        public GetCitiesByDistrictResponse()
        {
        }
        
        public GetCitiesByDistrictResponse(ServiceReference1.GetCitiesByDistrictResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCitiesByDistrictResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceReference1.City[] GetCitiesByDistrictResult;
        
        public GetCitiesByDistrictResponseBody()
        {
        }
        
        public GetCitiesByDistrictResponseBody(ServiceReference1.City[] GetCitiesByDistrictResult)
        {
            this.GetCitiesByDistrictResult = GetCitiesByDistrictResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface WebService1SoapChannel : ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<ServiceReference1.WebService1Soap>, ServiceReference1.WebService1Soap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WebService1SoapClient(EndpointConfiguration endpointConfiguration) : 
                base(WebService1SoapClient.GetBindingForEndpoint(endpointConfiguration), WebService1SoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebService1SoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WebService1SoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebService1SoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WebService1SoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.GetAllCountriesResponse> ServiceReference1.WebService1Soap.GetAllCountriesAsync(ServiceReference1.GetAllCountriesRequest request)
        {
            return base.Channel.GetAllCountriesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GetAllCountriesResponse> GetAllCountriesAsync()
        {
            ServiceReference1.GetAllCountriesRequest inValue = new ServiceReference1.GetAllCountriesRequest();
            inValue.Body = new ServiceReference1.GetAllCountriesRequestBody();
            return ((ServiceReference1.WebService1Soap)(this)).GetAllCountriesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.GetCountryByCodeResponse> ServiceReference1.WebService1Soap.GetCountryByCodeAsync(ServiceReference1.GetCountryByCodeRequest request)
        {
            return base.Channel.GetCountryByCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GetCountryByCodeResponse> GetCountryByCodeAsync(string code)
        {
            ServiceReference1.GetCountryByCodeRequest inValue = new ServiceReference1.GetCountryByCodeRequest();
            inValue.Body = new ServiceReference1.GetCountryByCodeRequestBody();
            inValue.Body.code = code;
            return ((ServiceReference1.WebService1Soap)(this)).GetCountryByCodeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.GetCityByNameResponse> ServiceReference1.WebService1Soap.GetCityByNameAsync(ServiceReference1.GetCityByNameRequest request)
        {
            return base.Channel.GetCityByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GetCityByNameResponse> GetCityByNameAsync(string name)
        {
            ServiceReference1.GetCityByNameRequest inValue = new ServiceReference1.GetCityByNameRequest();
            inValue.Body = new ServiceReference1.GetCityByNameRequestBody();
            inValue.Body.name = name;
            return ((ServiceReference1.WebService1Soap)(this)).GetCityByNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.GetAllCitiesByCountryCodeResponse> ServiceReference1.WebService1Soap.GetAllCitiesByCountryCodeAsync(ServiceReference1.GetAllCitiesByCountryCodeRequest request)
        {
            return base.Channel.GetAllCitiesByCountryCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GetAllCitiesByCountryCodeResponse> GetAllCitiesByCountryCodeAsync(string countryCode)
        {
            ServiceReference1.GetAllCitiesByCountryCodeRequest inValue = new ServiceReference1.GetAllCitiesByCountryCodeRequest();
            inValue.Body = new ServiceReference1.GetAllCitiesByCountryCodeRequestBody();
            inValue.Body.countryCode = countryCode;
            return ((ServiceReference1.WebService1Soap)(this)).GetAllCitiesByCountryCodeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.GetCitiesByDistrictResponse> ServiceReference1.WebService1Soap.GetCitiesByDistrictAsync(ServiceReference1.GetCitiesByDistrictRequest request)
        {
            return base.Channel.GetCitiesByDistrictAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GetCitiesByDistrictResponse> GetCitiesByDistrictAsync(string district)
        {
            ServiceReference1.GetCitiesByDistrictRequest inValue = new ServiceReference1.GetCitiesByDistrictRequest();
            inValue.Body = new ServiceReference1.GetCitiesByDistrictRequestBody();
            inValue.Body.district = district;
            return ((ServiceReference1.WebService1Soap)(this)).GetCitiesByDistrictAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WebService1Soap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.WebService1Soap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WebService1Soap))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:44390/WebService1.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.WebService1Soap12))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:44390/WebService1.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            WebService1Soap,
            
            WebService1Soap12,
        }
    }
}
