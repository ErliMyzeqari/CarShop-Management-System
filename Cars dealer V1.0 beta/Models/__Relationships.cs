using Micron;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Models
{

#region BRANDS
 public partial class Brand
 {
public MicronDbContext DefaultDBContext { get; set; }

   public bool HasModels(string where="true") {return DefaultDBContext.GetRecords<Model>("BrandID = "+this.BrandID+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<Model> GetModels(string where="true") {return DefaultDBContext.GetRecords<Model>("BrandID = "+this.BrandID+" AND "+where);}
    public void AddModel(Model model) { model.SetBrand(this); }
    public void AddModels(IEnumerable<Model> models) {foreach(var model in models) model.SetBrand(this); }

 }
#endregion
#region CLIENTS
 public partial class Client
 {
public MicronDbContext DefaultDBContext { get; set; }

   public bool HasReservations(string where="true") {return DefaultDBContext.GetRecords<Reservation>("ClientID = "+this.ClientID+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<Reservation> GetReservations(string where="true") {return DefaultDBContext.GetRecords<Reservation>("ClientID = "+this.ClientID+" AND "+where);}
    public void AddReservation(Reservation model) { model.SetClient(this); }
    public void AddReservations(IEnumerable<Reservation> models) {foreach(var model in models) model.SetClient(this); }

 }
#endregion
#region EXPENSES
 public partial class Expens
 {
public MicronDbContext DefaultDBContext { get; set; }
  public  Vehicle GetVehicle() { return DefaultDBContext.GetRecord<Vehicle>(this.VehicleID); }
   public void SetVehicle(Vehicle model)  {  DefaultDBContext.SetRelation(this, model);}
  public  User GetUser() { return DefaultDBContext.GetRecord<User>(this.CreatedBy); }
   public void SetUser(User model)  {  DefaultDBContext.SetRelation(this, model);}


 }
#endregion
#region MODELS
 public partial class Model
 {
public MicronDbContext DefaultDBContext { get; set; }
  public  Brand GetBrand() { return DefaultDBContext.GetRecord<Brand>(this.BrandID); }
   public void SetBrand(Brand model)  {  DefaultDBContext.SetRelation(this, model);}

   public bool HasVehicles(string where="true") {return DefaultDBContext.GetRecords<Vehicle>("ModelID = "+this.ModelID+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<Vehicle> GetVehicles(string where="true") {return DefaultDBContext.GetRecords<Vehicle>("ModelID = "+this.ModelID+" AND "+where);}
    public void AddVehicle(Vehicle model) { model.SetModel(this); }
    public void AddVehicles(IEnumerable<Vehicle> models) {foreach(var model in models) model.SetModel(this); }

 }
#endregion
#region PAYMENTS
 public partial class Payment
 {
public MicronDbContext DefaultDBContext { get; set; }
  public  Reservation GetReservation() { return DefaultDBContext.GetRecord<Reservation>(this.ReservationID); }
   public void SetReservation(Reservation model)  {  DefaultDBContext.SetRelation(this, model);}
  public  User GetUser() { return DefaultDBContext.GetRecord<User>(this.ReceivedBy); }
   public void SetUser(User model)  {  DefaultDBContext.SetRelation(this, model);}


 }
#endregion
#region RESERVATIONS
 public partial class Reservation
 {
public MicronDbContext DefaultDBContext { get; set; }
  public  Client GetClient() { return DefaultDBContext.GetRecord<Client>(this.ClientID); }
   public void SetClient(Client model)  {  DefaultDBContext.SetRelation(this, model);}
  public  Vehicle GetVehicle() { return DefaultDBContext.GetRecord<Vehicle>(this.VehicleID); }
   public void SetVehicle(Vehicle model)  {  DefaultDBContext.SetRelation(this, model);}
  public  User GetUser() { return DefaultDBContext.GetRecord<User>(this.ReservedBy); }
   public void SetUser(User model)  {  DefaultDBContext.SetRelation(this, model);}

   public bool HasPayments(string where="true") {return DefaultDBContext.GetRecords<Payment>("ReservationID = "+this.ReservatonID+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<Payment> GetPayments(string where="true") {return DefaultDBContext.GetRecords<Payment>("ReservationID = "+this.ReservatonID+" AND "+where);}
    public void AddPayment(Payment model) { model.SetReservation(this); }
    public void AddPayments(IEnumerable<Payment> models) {foreach(var model in models) model.SetReservation(this); }

 }
#endregion
#region SELLERS
 public partial class Seller
 {
public MicronDbContext DefaultDBContext { get; set; }

   public bool HasVehicles(string where="true") {return DefaultDBContext.GetRecords<Vehicle>("SellerID = "+this.SellerID+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<Vehicle> GetVehicles(string where="true") {return DefaultDBContext.GetRecords<Vehicle>("SellerID = "+this.SellerID+" AND "+where);}
    public void AddVehicle(Vehicle model) { model.SetSeller(this); }
    public void AddVehicles(IEnumerable<Vehicle> models) {foreach(var model in models) model.SetSeller(this); }

 }
#endregion
#region TASKS
 public partial class Task
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region USERS
 public partial class User
 {
public MicronDbContext DefaultDBContext { get; set; }

   public bool HasExpenses(string where="true") {return DefaultDBContext.GetRecords<Expens>("CreatedBy = "+this.UserID+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<Expens> GetExpenses(string where="true") {return DefaultDBContext.GetRecords<Expens>("CreatedBy = "+this.UserID+" AND "+where);}
    public void AddExpens(Expens model) { model.SetUser(this); }
    public void AddExpenses(IEnumerable<Expens> models) {foreach(var model in models) model.SetUser(this); }
   public bool HasPayments(string where="true") {return DefaultDBContext.GetRecords<Payment>("ReceivedBy = "+this.UserID+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<Payment> GetPayments(string where="true") {return DefaultDBContext.GetRecords<Payment>("ReceivedBy = "+this.UserID+" AND "+where);}
    public void AddPayment(Payment model) { model.SetUser(this); }
    public void AddPayments(IEnumerable<Payment> models) {foreach(var model in models) model.SetUser(this); }
   public bool HasReservations(string where="true") {return DefaultDBContext.GetRecords<Reservation>("ReservedBy = "+this.UserID+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<Reservation> GetReservations(string where="true") {return DefaultDBContext.GetRecords<Reservation>("ReservedBy = "+this.UserID+" AND "+where);}
    public void AddReservation(Reservation model) { model.SetUser(this); }
    public void AddReservations(IEnumerable<Reservation> models) {foreach(var model in models) model.SetUser(this); }
   public bool HasVehicles(string where="true") {return DefaultDBContext.GetRecords<Vehicle>("CreatedBy = "+this.UserID+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<Vehicle> GetVehicles(string where="true") {return DefaultDBContext.GetRecords<Vehicle>("CreatedBy = "+this.UserID+" AND "+where);}
    public void AddVehicle(Vehicle model) { model.SetUser(this); }
    public void AddVehicles(IEnumerable<Vehicle> models) {foreach(var model in models) model.SetUser(this); }

 }
#endregion
#region VEHICLES
 public partial class Vehicle
 {
public MicronDbContext DefaultDBContext { get; set; }
  public  Model GetModel() { return DefaultDBContext.GetRecord<Model>(this.ModelID); }
   public void SetModel(Model model)  {  DefaultDBContext.SetRelation(this, model);}
  public  Seller GetSeller() { return DefaultDBContext.GetRecord<Seller>(this.SellerID); }
   public void SetSeller(Seller model)  {  DefaultDBContext.SetRelation(this, model);}
  public  User GetUser() { return DefaultDBContext.GetRecord<User>(this.CreatedBy); }
   public void SetUser(User model)  {  DefaultDBContext.SetRelation(this, model);}

   public bool HasExpenses(string where="true") {return DefaultDBContext.GetRecords<Expens>("VehicleID = "+this.VehicleID+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<Expens> GetExpenses(string where="true") {return DefaultDBContext.GetRecords<Expens>("VehicleID = "+this.VehicleID+" AND "+where);}
    public void AddExpens(Expens model) { model.SetVehicle(this); }
    public void AddExpenses(IEnumerable<Expens> models) {foreach(var model in models) model.SetVehicle(this); }
   public bool HasReservations(string where="true") {return DefaultDBContext.GetRecords<Reservation>("VehicleID = "+this.VehicleID+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<Reservation> GetReservations(string where="true") {return DefaultDBContext.GetRecords<Reservation>("VehicleID = "+this.VehicleID+" AND "+where);}
    public void AddReservation(Reservation model) { model.SetVehicle(this); }
    public void AddReservations(IEnumerable<Reservation> models) {foreach(var model in models) model.SetVehicle(this); }

 }
#endregion

}
