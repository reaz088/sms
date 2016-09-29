<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="Teacher.aspx.cs" Inherits="BasicSetup_Teacher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
         <link href='http://fonts.googleapis.com/css?family=Roboto:300italic,400italic,300,400,500,700,900' rel='stylesheet' type='text/css'/>
        <link href="../vendor/bootstrap-3.3.2-dist/css/bootstrap.min.css" rel="stylesheet" />
        <link href="../css/admin/default.css" rel="stylesheet" />
        <link href="../css/admin/index.css" rel="stylesheet" />

        <link href="../vendor/angular-material/css/angular-material.css" rel="stylesheet" />

        <link href="../css/admin/index.css" rel="stylesheet" />
        <%--        <link href="../vendor/angular-material/css/docs.css" rel="stylesheet" />--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="dashboard-con" data-ng-controller="teacherCtrl as vm" class="container-fluid">
            <div class="row">
              <div class="col-md-12 dashboard-left-cell">
                <div class="admin-content-con">
                  <header class="clearfix">
                    <h4 class="pull-left">{{vm.title}}</h4>
                      <md-button class="md-raised md-primary pull-right" data-ng-click="vm.entry_form=!vm.entry_form"> {{vm.entry_form === true ? "Data List" : "Create new"}}</md-button>
                    
                  </header>
                    <div data-ng-if="vm.entry_form==true">
                        <div class="row">
                        <div class="col-md-8">
                        <div  class="x-box x-box">
                            <div class="x-box-head style-primary">
	                            <header>Create New</header>
                            </div>
                          <div class="x-box-body">
               
<%--                              teacher.teacher_short_name
teacher.teacher_address
teacher.designation_id
teacher.gender_id
teacher.contact_number
teacher.official_number
teacher.email--%>
                              <md-input-container class="md-block">
                                <label>Teacher Name</label>
                                <input type="text" data-ng-model="vm.objTeacher.teacher_name"/>
                             </md-input-container>
                              <md-input-container class="md-block">
                                <label>Short Name</label>
                                <input type="text" data-ng-model="vm.objTeacher.teacher_short_name"/>
                             </md-input-container> 
                              <div class="form-group">

                                        <label>
                                            Designation
                                        </label>
                                        <select class="form-control form-control-sm"
                                                ng-model="vm.cmbDesignations"
                                                ng-options="designation.designation_name for designation in vm.Designations track by designation.designation_id "
                                                ng-change="vm.objTeacher.designation_id=vm.cmbDesignations.designation_id">
                                        </select>
                               </div> 
                               <md-input-container class="md-block">
                                <label>Address</label>
                                <textarea type="text" data-ng-model="vm.objTeacher.teacher_address"  md-maxlength="150" rows="5" md-select-on-focus></textarea>
                             </md-input-container>  
                              <md-input-container>
                                <label>Contact Number</label>
                                <input type="text" data-ng-model="vm.objTeacher.contact_number"/>
                              </md-input-container>
                              <md-input-container>
                                <label>Official Number</label>
                                <input type="text" data-ng-model="vm.objTeacher.official_number"/>
                              </md-input-container>
                               <md-input-container>
                                <label>email</label>
                                <input type="text" data-ng-model="vm.objTeacher.email"/>
                              </md-input-container>                                                      

                              <div class="form-group">
                                  <label class="radio-inline">
                                        <input type="radio" name="inlineRadioOptions" data-ng-model="vm.objTeacher.gender_id"  data-ng-value="1"> Male
                                    </label>
                                    <label class="radio-inline">
                                        <input type="radio" name="inlineRadioOptions" data-ng-model="vm.objTeacher.gender_id" data-ng-value="2"> Female
                                   </label>
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
                                    <th>Teacher</th>
                                    <th>Dhort Name</th>
                                    <th>Designation</th>
                                    <th>Email</th>
                                    <th>Mobile</th>
                                    <th>gender</th>
                                    <th>actions</th>
                                  </tr>
                                </thead>
                                <tbody>
                                  <tr data-ng-repeat="d in vm.teachers">
                                    <td>{{d.teacher_id}}</td>
                                    <td>{{d.teacher_name}}</td> 
                                    <td>{{d.teacher_short_name}}</td>
                                    <td>{{d.designation_name}}</td>
                                    <td>{{d.email}}</td>
                                    <td>{{d.contact_number}}</td>
                                    <td>{{d.gender_name}}</td>

                                    <td>
                                      <a class="btn btn-xs btn-warning" href="#" data-ng-click="vm.view(d)" role="button">edit</a>
                                      <a class="btn btn-xs btn-primary" href="#" data-ng-click="vm.view(d)" role="button">view</a>
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
            <script src="teacher.js"></script>
          </div>
</asp:Content>

