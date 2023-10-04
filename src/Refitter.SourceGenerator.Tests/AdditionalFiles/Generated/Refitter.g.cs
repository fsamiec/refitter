﻿// <auto-generated>
//     This code was generated by Refitter.
// </auto-generated>


using Refit;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Refitter.Tests.AdditionalFiles.NoFilename
{
    [System.CodeDom.Compiler.GeneratedCode("Refitter", "1.0.0.0")]
    public partial interface ISwaggerPetstore
    {
        /// <summary>
        /// Update an existing pet by Id
        /// </summary>
        [Headers("Accept: application/xml, application/json")]
        [Put("/pet")]
        Task<Pet> UpdatePet([Body] Pet body);

        /// <summary>
        /// Add a new pet to the store
        /// </summary>
        [Headers("Accept: application/xml, application/json")]
        [Post("/pet")]
        Task<Pet> AddPet([Body] Pet body);

        /// <summary>
        /// Multiple status values can be provided with comma separated strings
        /// </summary>
        [Headers("Accept: application/json")]
        [Get("/pet/findByStatus")]
        Task<ICollection<Pet>> FindPetsByStatus([Query] Status? status);

        /// <summary>
        /// Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.
        /// </summary>
        [Headers("Accept: application/json")]
        [Get("/pet/findByTags")]
        Task<ICollection<Pet>> FindPetsByTags([Query(CollectionFormat.Multi)] IEnumerable<string> tags);

        /// <summary>
        /// Returns a single pet
        /// </summary>
        [Headers("Accept: application/xml, application/json")]
        [Get("/pet/{petId}")]
        Task<Pet> GetPetById(long petId);

        [Post("/pet/{petId}")]
        Task UpdatePetWithForm(long petId, [Query] string name, [Query] string status);

        [Delete("/pet/{petId}")]
        Task DeletePet(long petId, [Header("api_key")] string api_key);

        [Headers("Accept: application/json")]
        [Post("/pet/{petId}/uploadImage")]
        Task<ApiResponse> UploadFile(long petId, [Query] string additionalMetadata, StreamPart body);

        /// <summary>
        /// Returns a map of status codes to quantities
        /// </summary>
        [Headers("Accept: application/json")]
        [Get("/store/inventory")]
        Task<IDictionary<string, int>> GetInventory();

        /// <summary>
        /// Place a new order in the store
        /// </summary>
        [Headers("Accept: application/json")]
        [Post("/store/order")]
        Task<Order> PlaceOrder([Body] Order body);

        /// <summary>
        /// For valid response try integer IDs with value <= 5 or > 10. Other values will generated exceptions
        /// </summary>
        [Headers("Accept: application/json")]
        [Get("/store/order/{orderId}")]
        Task<Order> GetOrderById(long orderId);

        /// <summary>
        /// For valid response try integer IDs with value < 1000. Anything above 1000 or nonintegers will generate API errors
        /// </summary>
        [Delete("/store/order/{orderId}")]
        Task DeleteOrder(long orderId);

        /// <summary>
        /// This can only be done by the logged in user.
        /// </summary>
        [Headers("Accept: application/json, application/xml")]
        [Post("/user")]
        Task CreateUser([Body] User body);

        /// <summary>
        /// Creates list of users with given input array
        /// </summary>
        [Headers("Accept: application/xml, application/json")]
        [Post("/user/createWithList")]
        Task<User> CreateUsersWithListInput([Body] IEnumerable<User> body);

        [Headers("Accept: application/json")]
        [Get("/user/login")]
        Task<string> LoginUser([Query] string username, [Query] string password);

        [Get("/user/logout")]
        Task LogoutUser();

        [Headers("Accept: application/json")]
        [Get("/user/{username}")]
        Task<User> GetUserByName(string username);

        /// <summary>
        /// This can only be done by the logged in user.
        /// </summary>
        [Put("/user/{username}")]
        Task UpdateUser(string username, [Body] User body);

        /// <summary>
        /// This can only be done by the logged in user.
        /// </summary>
        [Delete("/user/{username}")]
        Task DeleteUser(string username);


    }
}


//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 612 // Disable "CS0612 '...' is obsolete"
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"
#pragma warning disable 8604 // Disable "CS8604 Possible null reference argument for parameter"

namespace Refitter.Tests.AdditionalFiles.NoFilename
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0))")]
    public partial class Order
    {

        [JsonPropertyName("id")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public long Id { get; set; }

        [JsonPropertyName("petId")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public long PetId { get; set; }

        [JsonPropertyName("quantity")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public int Quantity { get; set; }

        [JsonPropertyName("shipDate")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public System.DateTimeOffset ShipDate { get; set; }

        /// <summary>
        /// Order Status
        /// </summary>

        [JsonPropertyName("status")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public OrderStatus Status { get; set; }

        [JsonPropertyName("complete")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public bool Complete { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0))")]
    public partial class Customer
    {

        [JsonPropertyName("id")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public long Id { get; set; }

        [JsonPropertyName("username")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public string Username { get; set; }

        [JsonPropertyName("address")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public ICollection<Address> Address { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0))")]
    public partial class Address
    {

        [JsonPropertyName("street")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public string Street { get; set; }

        [JsonPropertyName("city")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public string City { get; set; }

        [JsonPropertyName("state")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public string State { get; set; }

        [JsonPropertyName("zip")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public string Zip { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0))")]
    public partial class Category
    {

        [JsonPropertyName("id")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public long Id { get; set; }

        [JsonPropertyName("name")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public string Name { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0))")]
    public partial class User
    {

        [JsonPropertyName("id")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public long Id { get; set; }

        [JsonPropertyName("username")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public string Username { get; set; }

        [JsonPropertyName("firstName")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public string LastName { get; set; }

        [JsonPropertyName("email")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public string Email { get; set; }

        [JsonPropertyName("password")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public string Password { get; set; }

        [JsonPropertyName("phone")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public string Phone { get; set; }

        /// <summary>
        /// User Status
        /// </summary>

        [JsonPropertyName("userStatus")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public int UserStatus { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0))")]
    public partial class Tag
    {

        [JsonPropertyName("id")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public long Id { get; set; }

        [JsonPropertyName("name")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public string Name { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0))")]
    public partial class Pet
    {

        [JsonPropertyName("id")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public long Id { get; set; }

        [JsonPropertyName("name")]

        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]   
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }

        [JsonPropertyName("category")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public Category Category { get; set; }

        [JsonPropertyName("photoUrls")]

        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]   
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<string> PhotoUrls { get; set; } = new System.Collections.ObjectModel.Collection<string>();

        [JsonPropertyName("tags")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public ICollection<Tag> Tags { get; set; }

        /// <summary>
        /// pet status in the store
        /// </summary>

        [JsonPropertyName("status")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetStatus Status { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0))")]
    public partial class ApiResponse
    {

        [JsonPropertyName("code")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public int Code { get; set; }

        [JsonPropertyName("type")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public string Type { get; set; }

        [JsonPropertyName("message")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]   
        public string Message { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0))")]
    public enum Status
    {

        [System.Runtime.Serialization.EnumMember(Value = @"available")]
        Available = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"pending")]
        Pending = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"sold")]
        Sold = 2,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0))")]
    public enum OrderStatus
    {

        [System.Runtime.Serialization.EnumMember(Value = @"placed")]
        Placed = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"approved")]
        Approved = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"delivered")]
        Delivered = 2,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0))")]
    public enum PetStatus
    {

        [System.Runtime.Serialization.EnumMember(Value = @"available")]
        Available = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"pending")]
        Pending = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"sold")]
        Sold = 2,

    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0))")]
    public partial class FileParameter
    {
        public FileParameter(System.IO.Stream data)
            : this (data, null, null)
        {
        }

        public FileParameter(System.IO.Stream data, string fileName)
            : this (data, fileName, null)
        {
        }

        public FileParameter(System.IO.Stream data, string fileName, string contentType)
        {
            Data = data;
            FileName = fileName;
            ContentType = contentType;
        }

        public System.IO.Stream Data { get; private set; }

        public string FileName { get; private set; }

        public string ContentType { get; private set; }
    }


}

#pragma warning restore  108
#pragma warning restore  114
#pragma warning restore  472
#pragma warning restore  612
#pragma warning restore 1573
#pragma warning restore 1591
#pragma warning restore 8073
#pragma warning restore 3016
#pragma warning restore 8603
#pragma warning restore 8604