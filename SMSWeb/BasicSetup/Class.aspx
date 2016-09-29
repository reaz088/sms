<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="Class.aspx.cs" Inherits="BasicSetup_Class" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href='http://fonts.googleapis.com/css?family=Roboto:300italic,400italic,300,400,500,700,900' rel='stylesheet' type='text/css'/>
        <link href="../vendor/bootstrap-3.3.2-dist/css/bootstrap.min.css" rel="stylesheet" />
        <link href="../css/admin/default.css" rel="stylesheet" />
        <link href="../css/admin/index.css" rel="stylesheet" />
        <link href="../vendor/angular-material/css/angular-material.css" rel="stylesheet" />
<%--        <link href="../vendor/angular-material/css/docs.css" rel="stylesheet" />--%>
     <link href="../css/admin/index.css" rel="stylesheet" />   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div id="dashboard-con" data-ng-controller="myCntrl as vm" class="container-fluid">
            <div class="row">
              <div class="col-md-12 dashboard-left-cell">
                <div class="admin-content-con">
                  <header class="clearfix">
                    <h4 class="pull-left">Classes</h4>
                      <md-button class="md-raised md-primary pull-right" data-ng-click="vm.entry_form=!vm.entry_form"> {{vm.entry_form === true ? "Data List" : "Create new"}}</md-button>
                  </header>
                    <div data-ng-if="vm.entry_form==true">
                        <div class="row">
                        <div class="col-md-8">
                        <div  class="x-box x-box">
                            <div class="x-box-head style-primary">
	                            <header>Create a Class</header>
                            </div>
                          <div class="x-box-body">
               
                              <md-input-container class="md-block">
                                <label>Class Name</label>
                                <input type="text" data-ng-model="vm.objclass.class_name"/>
                             </md-input-container>

                              <md-input-container class="md-block">
                                <label>Short Name</label> 
                                  <input type="text" data-ng-model="vm.objclass.short_name"/>
                              </md-input-container>
                              <div class="form-group">

                                        <label>
                                            Teacher
                                        </label>
                                        <select class="form-control form-control-sm"
                                                ng-model="vm.cmbTeachers"
                                                ng-options="teacher.teacher_name for teacher in vm.Teachers track by teacher.teacher_id "
                                                ng-change="vm.objclass.teacher_id=vm.cmbTeachers.teacher_id">
                                        </select>
                               </div> 

                              <div class="x-box-foot">
                                  <md-button data-ng-if="vm.btnSave==true" class="md-raised md-primary" data-ng-click="vm.Save()" >Save</md-button>
                                  <md-button data-ng-if="vm.btnUpdate==true" class="md-raised md-primary" data-ng-click="vm.Put()" >Update</md-button>
                                  <md-button data-ng-if="vm.btnRefresh==true" class="md-raised md-primary" data-ng-click="vm.Refresh()" >Refresh</md-button>
                              </div>
               
                          </div>
                        </div>
                      </div>
                     </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="x-box">
                                <div class="x-box-body">
                                     <table class="table table-striped">
                                <thead>
                                  <tr>
                                    <th>ID</th>
                                    <th>Class</th>
                                    <th>Short Name</th>
                                    <th>Teacher</th>
                        
                                    <th>actions</th>
                                  </tr>
                                </thead>
                                <tbody>
                                  <tr data-ng-repeat="c in vm.classes">
                                    <td>{{c.class_id}}</td>
                                    <td>{{c.class_name}}</td>
                                    <td>{{c.short_name}}</td>
                                    <td>{{c.teacher_name}}</td>
                                    <td>
                                      <a class="btn btn-xs btn-warning" href="#" data-ng-click="vm.view(c)" role="button">edit</a>
                                      <a class="btn btn-xs btn-primary" href="#" data-ng-click="vm.view(c)" role="button">view</a>
                                      <a class="btn btn-xs btn-danger" href="#" role="button">del</a>
                                    </td>
                                  </tr>
                                </tbody>
                              </table>
                                </div>
                            </div>
                        </div>
                    </div>
                  <div class="clearfix">
                    <a href="#" class="pull-right text-link">view all articles</a>
                  </div>
                </div>
              </div>

             
            </div>
            <script src="class.js"></script>
          </div>


</asp:Content>

