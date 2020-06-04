﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCountrys", ReplyAction="http://tempuri.org/IService1/GetCountrysResponse")]
        ApplicationSeriveces.DTOs.CountryDTO[] GetCountrys();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCountrys", ReplyAction="http://tempuri.org/IService1/GetCountrysResponse")]
        System.Threading.Tasks.Task<ApplicationSeriveces.DTOs.CountryDTO[]> GetCountrysAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCountryById", ReplyAction="http://tempuri.org/IService1/GetCountryByIdResponse")]
        ApplicationSeriveces.DTOs.CountryDTO GetCountryById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCountryById", ReplyAction="http://tempuri.org/IService1/GetCountryByIdResponse")]
        System.Threading.Tasks.Task<ApplicationSeriveces.DTOs.CountryDTO> GetCountryByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostCountry", ReplyAction="http://tempuri.org/IService1/PostCountryResponse")]
        string PostCountry(ApplicationSeriveces.DTOs.CountryDTO CountryDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostCountry", ReplyAction="http://tempuri.org/IService1/PostCountryResponse")]
        System.Threading.Tasks.Task<string> PostCountryAsync(ApplicationSeriveces.DTOs.CountryDTO CountryDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutCountry", ReplyAction="http://tempuri.org/IService1/PutCountryResponse")]
        string PutCountry(ApplicationSeriveces.DTOs.CountryDTO CountryDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutCountry", ReplyAction="http://tempuri.org/IService1/PutCountryResponse")]
        System.Threading.Tasks.Task<string> PutCountryAsync(ApplicationSeriveces.DTOs.CountryDTO CountryDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCountry", ReplyAction="http://tempuri.org/IService1/DeleteCountryResponse")]
        string DeleteCountry(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCountry", ReplyAction="http://tempuri.org/IService1/DeleteCountryResponse")]
        System.Threading.Tasks.Task<string> DeleteCountryAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllCountrysByName", ReplyAction="http://tempuri.org/IService1/GetAllCountrysByNameResponse")]
        ApplicationSeriveces.DTOs.CountryDTO[] GetAllCountrysByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllCountrysByName", ReplyAction="http://tempuri.org/IService1/GetAllCountrysByNameResponse")]
        System.Threading.Tasks.Task<ApplicationSeriveces.DTOs.CountryDTO[]> GetAllCountrysByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetRegions", ReplyAction="http://tempuri.org/IService1/GetRegionsResponse")]
        ApplicationSeriveces.DTOs.RegionDTO[] GetRegions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetRegions", ReplyAction="http://tempuri.org/IService1/GetRegionsResponse")]
        System.Threading.Tasks.Task<ApplicationSeriveces.DTOs.RegionDTO[]> GetRegionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetRegionById", ReplyAction="http://tempuri.org/IService1/GetRegionByIdResponse")]
        ApplicationSeriveces.DTOs.RegionDTO GetRegionById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetRegionById", ReplyAction="http://tempuri.org/IService1/GetRegionByIdResponse")]
        System.Threading.Tasks.Task<ApplicationSeriveces.DTOs.RegionDTO> GetRegionByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostRegion", ReplyAction="http://tempuri.org/IService1/PostRegionResponse")]
        string PostRegion(ApplicationSeriveces.DTOs.RegionDTO regionDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostRegion", ReplyAction="http://tempuri.org/IService1/PostRegionResponse")]
        System.Threading.Tasks.Task<string> PostRegionAsync(ApplicationSeriveces.DTOs.RegionDTO regionDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutRegion", ReplyAction="http://tempuri.org/IService1/PutRegionResponse")]
        string PutRegion(ApplicationSeriveces.DTOs.RegionDTO regionDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutRegion", ReplyAction="http://tempuri.org/IService1/PutRegionResponse")]
        System.Threading.Tasks.Task<string> PutRegionAsync(ApplicationSeriveces.DTOs.RegionDTO regionDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRegion", ReplyAction="http://tempuri.org/IService1/DeleteRegionResponse")]
        string DeleteRegion(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRegion", ReplyAction="http://tempuri.org/IService1/DeleteRegionResponse")]
        System.Threading.Tasks.Task<string> DeleteRegionAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllRegionsByName", ReplyAction="http://tempuri.org/IService1/GetAllRegionsByNameResponse")]
        ApplicationSeriveces.DTOs.RegionDTO[] GetAllRegionsByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllRegionsByName", ReplyAction="http://tempuri.org/IService1/GetAllRegionsByNameResponse")]
        System.Threading.Tasks.Task<ApplicationSeriveces.DTOs.RegionDTO[]> GetAllRegionsByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPlaces", ReplyAction="http://tempuri.org/IService1/GetPlacesResponse")]
        ApplicationSeriveces.DTOs.PlaceDTO[] GetPlaces();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPlaces", ReplyAction="http://tempuri.org/IService1/GetPlacesResponse")]
        System.Threading.Tasks.Task<ApplicationSeriveces.DTOs.PlaceDTO[]> GetPlacesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPlaceById", ReplyAction="http://tempuri.org/IService1/GetPlaceByIdResponse")]
        ApplicationSeriveces.DTOs.PlaceDTO GetPlaceById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPlaceById", ReplyAction="http://tempuri.org/IService1/GetPlaceByIdResponse")]
        System.Threading.Tasks.Task<ApplicationSeriveces.DTOs.PlaceDTO> GetPlaceByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostPlace", ReplyAction="http://tempuri.org/IService1/PostPlaceResponse")]
        string PostPlace(ApplicationSeriveces.DTOs.PlaceDTO PlaceDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostPlace", ReplyAction="http://tempuri.org/IService1/PostPlaceResponse")]
        System.Threading.Tasks.Task<string> PostPlaceAsync(ApplicationSeriveces.DTOs.PlaceDTO PlaceDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutPlace", ReplyAction="http://tempuri.org/IService1/PutPlaceResponse")]
        string PutPlace(ApplicationSeriveces.DTOs.PlaceDTO PlaceDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutPlace", ReplyAction="http://tempuri.org/IService1/PutPlaceResponse")]
        System.Threading.Tasks.Task<string> PutPlaceAsync(ApplicationSeriveces.DTOs.PlaceDTO PlaceDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePlace", ReplyAction="http://tempuri.org/IService1/DeletePlaceResponse")]
        string DeletePlace(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePlace", ReplyAction="http://tempuri.org/IService1/DeletePlaceResponse")]
        System.Threading.Tasks.Task<string> DeletePlaceAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPlacesByName", ReplyAction="http://tempuri.org/IService1/GetAllPlacesByNameResponse")]
        ApplicationSeriveces.DTOs.PlaceDTO[] GetAllPlacesByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPlacesByName", ReplyAction="http://tempuri.org/IService1/GetAllPlacesByNameResponse")]
        System.Threading.Tasks.Task<ApplicationSeriveces.DTOs.PlaceDTO[]> GetAllPlacesByNameAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MVC.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MVC.ServiceReference1.IService1>, MVC.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ApplicationSeriveces.DTOs.CountryDTO[] GetCountrys() {
            return base.Channel.GetCountrys();
        }
        
        public System.Threading.Tasks.Task<ApplicationSeriveces.DTOs.CountryDTO[]> GetCountrysAsync() {
            return base.Channel.GetCountrysAsync();
        }
        
        public ApplicationSeriveces.DTOs.CountryDTO GetCountryById(int id) {
            return base.Channel.GetCountryById(id);
        }
        
        public System.Threading.Tasks.Task<ApplicationSeriveces.DTOs.CountryDTO> GetCountryByIdAsync(int id) {
            return base.Channel.GetCountryByIdAsync(id);
        }
        
        public string PostCountry(ApplicationSeriveces.DTOs.CountryDTO CountryDTO) {
            return base.Channel.PostCountry(CountryDTO);
        }
        
        public System.Threading.Tasks.Task<string> PostCountryAsync(ApplicationSeriveces.DTOs.CountryDTO CountryDTO) {
            return base.Channel.PostCountryAsync(CountryDTO);
        }
        
        public string PutCountry(ApplicationSeriveces.DTOs.CountryDTO CountryDTO) {
            return base.Channel.PutCountry(CountryDTO);
        }
        
        public System.Threading.Tasks.Task<string> PutCountryAsync(ApplicationSeriveces.DTOs.CountryDTO CountryDTO) {
            return base.Channel.PutCountryAsync(CountryDTO);
        }
        
        public string DeleteCountry(int id) {
            return base.Channel.DeleteCountry(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteCountryAsync(int id) {
            return base.Channel.DeleteCountryAsync(id);
        }
        
        public ApplicationSeriveces.DTOs.CountryDTO[] GetAllCountrysByName(string name) {
            return base.Channel.GetAllCountrysByName(name);
        }
        
        public System.Threading.Tasks.Task<ApplicationSeriveces.DTOs.CountryDTO[]> GetAllCountrysByNameAsync(string name) {
            return base.Channel.GetAllCountrysByNameAsync(name);
        }
        
        public ApplicationSeriveces.DTOs.RegionDTO[] GetRegions() {
            return base.Channel.GetRegions();
        }
        
        public System.Threading.Tasks.Task<ApplicationSeriveces.DTOs.RegionDTO[]> GetRegionsAsync() {
            return base.Channel.GetRegionsAsync();
        }
        
        public ApplicationSeriveces.DTOs.RegionDTO GetRegionById(int id) {
            return base.Channel.GetRegionById(id);
        }
        
        public System.Threading.Tasks.Task<ApplicationSeriveces.DTOs.RegionDTO> GetRegionByIdAsync(int id) {
            return base.Channel.GetRegionByIdAsync(id);
        }
        
        public string PostRegion(ApplicationSeriveces.DTOs.RegionDTO regionDto) {
            return base.Channel.PostRegion(regionDto);
        }
        
        public System.Threading.Tasks.Task<string> PostRegionAsync(ApplicationSeriveces.DTOs.RegionDTO regionDto) {
            return base.Channel.PostRegionAsync(regionDto);
        }
        
        public string PutRegion(ApplicationSeriveces.DTOs.RegionDTO regionDto) {
            return base.Channel.PutRegion(regionDto);
        }
        
        public System.Threading.Tasks.Task<string> PutRegionAsync(ApplicationSeriveces.DTOs.RegionDTO regionDto) {
            return base.Channel.PutRegionAsync(regionDto);
        }
        
        public string DeleteRegion(int id) {
            return base.Channel.DeleteRegion(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteRegionAsync(int id) {
            return base.Channel.DeleteRegionAsync(id);
        }
        
        public ApplicationSeriveces.DTOs.RegionDTO[] GetAllRegionsByName(string name) {
            return base.Channel.GetAllRegionsByName(name);
        }
        
        public System.Threading.Tasks.Task<ApplicationSeriveces.DTOs.RegionDTO[]> GetAllRegionsByNameAsync(string name) {
            return base.Channel.GetAllRegionsByNameAsync(name);
        }
        
        public ApplicationSeriveces.DTOs.PlaceDTO[] GetPlaces() {
            return base.Channel.GetPlaces();
        }
        
        public System.Threading.Tasks.Task<ApplicationSeriveces.DTOs.PlaceDTO[]> GetPlacesAsync() {
            return base.Channel.GetPlacesAsync();
        }
        
        public ApplicationSeriveces.DTOs.PlaceDTO GetPlaceById(int id) {
            return base.Channel.GetPlaceById(id);
        }
        
        public System.Threading.Tasks.Task<ApplicationSeriveces.DTOs.PlaceDTO> GetPlaceByIdAsync(int id) {
            return base.Channel.GetPlaceByIdAsync(id);
        }
        
        public string PostPlace(ApplicationSeriveces.DTOs.PlaceDTO PlaceDTO) {
            return base.Channel.PostPlace(PlaceDTO);
        }
        
        public System.Threading.Tasks.Task<string> PostPlaceAsync(ApplicationSeriveces.DTOs.PlaceDTO PlaceDTO) {
            return base.Channel.PostPlaceAsync(PlaceDTO);
        }
        
        public string PutPlace(ApplicationSeriveces.DTOs.PlaceDTO PlaceDTO) {
            return base.Channel.PutPlace(PlaceDTO);
        }
        
        public System.Threading.Tasks.Task<string> PutPlaceAsync(ApplicationSeriveces.DTOs.PlaceDTO PlaceDTO) {
            return base.Channel.PutPlaceAsync(PlaceDTO);
        }
        
        public string DeletePlace(int id) {
            return base.Channel.DeletePlace(id);
        }
        
        public System.Threading.Tasks.Task<string> DeletePlaceAsync(int id) {
            return base.Channel.DeletePlaceAsync(id);
        }
        
        public ApplicationSeriveces.DTOs.PlaceDTO[] GetAllPlacesByName(string name) {
            return base.Channel.GetAllPlacesByName(name);
        }
        
        public System.Threading.Tasks.Task<ApplicationSeriveces.DTOs.PlaceDTO[]> GetAllPlacesByNameAsync(string name) {
            return base.Channel.GetAllPlacesByNameAsync(name);
        }
    }
}
