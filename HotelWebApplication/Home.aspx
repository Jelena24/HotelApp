<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="HotelWebApplication.Home" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" integrity="sha512-Fo3rlrZj/k7ujTnHg4CGR2D7kSs0v4LLanw2qksYuRlEzO+tcaEPQogQ0KaoGN26/zrn20ImR1DfuLWnOo7aBA==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <title>Hotel - Home</title>
</head>
<body style="height: 100vh;font-weight:600;background: linear-gradient(90deg, rgba(255,255,255,0.4), rgba(255,255,255,0.4)),
url('images/login.jpg');background-size: cover;background-repeat: no-repeat;">
    <form id="form1" runat="server">

    
    <div class="container w-50">
     
     <div class="row" style="color:rgb(110, 107, 107);display: flex;flex-direction: column; justify-content: center;height: 100vh;">
         <div class="row">
        <button id="getId" runat="server" onserverclick="getId_ServerClick" class="col-md-6 px-3 py-3" style="background: rgba(255, 255, 255, 0.8);border: 5px solid white; font-weight: 600;text-transform: uppercase; text-align: center;cursor: pointer;">
            <i class="fas fa-list"></i>
            <p>View Guests</p>
         </button>
        
         <button id="checkInId" runat="server" onserverclick="checkInId_ServerClick" class="col-md-6 px-3 py-3" style="background: rgba(255, 255, 255, 0.8);border: 5px solid white; font-weight: 600;text-transform: uppercase; text-align: center;cursor: pointer;">
            <i class="fas fa-plus"></i>
            <p>Check-in Guests</p>
         </button>  
         <button id="updateId" runat="server" onserverclick="updateId_ServerClick" class="col-md-6 px-3 py-3" style="background: rgba(255, 255, 255, 0.8);border: 5px solid white; font-weight: 600;text-transform: uppercase; text-align: center;cursor: pointer;">
            <i class="fas fa-pen-alt"></i>
            <p>Update Guests</p>
         </button>
         <button id="deleteId" runat="server" onserverclick="deleteId_ServerClick" class="col-md-6 px-3 py-3" style="background: rgba(255, 255, 255, 0.8);border: 5px solid white; font-weight: 600;text-transform: uppercase; text-align: center;cursor: pointer;">
            <i class="fas fa-dumpster"></i>
            <p>Check-out Guests</p>
         </button>
             <div class="container">
            <div class="container m-4">
         <div class="row">
          <div class="mb-3">
          <input type="text" placeholder="Identity Card number" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-2 mb-1" id="BrojLicneKarte" runat="server" >
        <input type="text" placeholder="Name" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-1 mb-1" id="Ime" runat="server" >
          <input type="text" placeholder="Surname" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-1 mb-1" id="Prezime" runat="server" >
         <input type="text" placeholder="Phone Number" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-1 mb-1" id="BrojTelefona" runat="server" >
          <input type="text" placeholder="Room Number" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-1 mb-2" id="BrojSobe" runat="server" >
              </div>
             </div>
          </div>
        <%--</div>--%>
         </div>
         
        </div>
          
        </div>
        <div id="allguests" runat="server" style="background:white">

        </div>
     </div>
        </form>
  
</body>
</html>