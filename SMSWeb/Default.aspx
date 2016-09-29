<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
     <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.5.0/angular.min.js"></script>
   
       
   
       

</head>
<body data-ng-app="smsApp">
    <form id="form1" runat="server">
    <div>
    <h1>Hello World!</h1>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
        </p>
    </div>
         <div>
                     <div data-ng-controller="myCntrl">
                      <input type="text" id="txtStudentName" data-ng-model="class_name" />
                         <input class="btn-primary" type="button" value="add" data-ng-click="Save()">  
                         <input class="btn-primary" type="button" value="add" data-ng-click="Result()">
                                    <br />  
                        Result from server: {{retData}}  
                    
                    </div>
                    </div>
          <script>
              var app = angular.module("smsApp", []);
              app.controller("myCntrl", function ($scope, $http) {
                  //$scope.studentorder = "StudetnID";
                  $scope.retData = {};
                  $scope.Save = function () {
                      var httpreq = {
                          method: 'POST',
                          url: 'Default.aspx/Save',
                          headers: {
                              'Content-Type': 'application/json; charset=utf-8',
                              'dataType': 'json'
                          },
                          data: { ClassName: $scope.class_name }
                      }
                      $http(httpreq).success(function (response) {
                          $scope.retData = response.d;
                          alert("Saved successfully.");
                      })
                  };
                  
                 
              });
    </script>
    </form>
</body>
</html>
