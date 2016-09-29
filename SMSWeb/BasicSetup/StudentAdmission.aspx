<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="StudentAdmission.aspx.cs" Inherits="BasicSetup_StudentAdmission" %>

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
    <div id="dashboard-con" data-ng-controller="studentAdmissionCtrl as vm" class="container-fluid">
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
               
                              <md-input-container class="md-block">
                                <label>Full Name</label>
                                <input type="text" data-ng-model="vm.objStudentAdmission.full_name"/>
                             </md-input-container>
                              <div class="form-group">

                                        <label>
                                            Class
                                        </label>
                                        <select class="form-control form-control-sm"
                                                ng-model="vm.cmbClasses"
                                                ng-options="class.class_name for class in vm.Classes track by class.class_id "
                                                ng-change="vm.objStudentAdmission.class_id=vm.cmbClasses.class_id">
                                        </select>
                              </div> 
                               <div class="form-group">
                                  <label class="radio-inline">
                                        <input type="radio" name="inlineRadioOptions" data-ng-model="vm.objStudentAdmission.gender_id"  data-ng-value="1"> Male
                                    </label>
                                    <label class="radio-inline">
                                        <input type="radio" name="inlineRadioOptions" data-ng-model="vm.objStudentAdmission.gender_id" data-ng-value="2"> Female
                                   </label>
                              </div>
                              <h4>Start On</h4>
                                <md-datepicker ng-model="vm.objStudentAdmission.admission_date" md-placeholder="Admission Date"></md-datepicker>
                                <h4>End On</h4>
                                <md-datepicker ng-model="vm.objStudentAdmission.date_of_birth" md-placeholder="Date of Birth"></md-datepicker>
                                <div class="form-group">

                                            <label>
                                                Session Year
                                            </label>
                                            <select class="form-control form-control-sm"
                                                    ng-model="vm.cmbSessionYears"
                                                    ng-options="sessionYear.description for sessionYear in vm.SessionYears track by sessionYear.session_id"
                                                    ng-change="vm.objStudentAdmission.academic_year_id=vm.cmbSessionYears.session_id">
                                            </select>
                                  </div> 
                              <div class="form-group">

                                        <label>
                                            Districts
                                        </label>
                                        <select class="form-control form-control-sm"
                                                ng-model="vm.cmbDistricts"
                                                ng-options="district.district_name for district in vm.Districts track by district.district_id "
                                                ng-change="vm.objStudentAdmission.district_id=vm.cmbDistricts.district_id">
                                        </select>
                              </div> 
                              <md-input-container class="md-block">
                                <label>Present Address</label>
                                <input type="text" data-ng-model="vm.objStudentAdmission.present_address"/>
                             </md-input-container>                              
                              <md-input-container class="md-block">
                                <label>Parmanent Address</label>
                                <input type="text" data-ng-model="vm.objStudentAdmission.parmanent_address"/>
                             </md-input-container>                              
                              <md-input-container class="md-block">
                                <label>First Contact No</label>
                                <input type="text" data-ng-model="vm.objStudentAdmission.first_contact_no"/>
                             </md-input-container>                              
                              <md-input-container class="md-block">
                                <label>Second Contact No</label>
                                <input type="text" data-ng-model="vm.objStudentAdmission.second_contact_no"/>
                             </md-input-container>


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
                                    <th>Full Name</th>
                                      <th>registration_no</th>
                                      <th >date_of_birth</th>
                                      <th >admission_date</th>
                                      <th>class</th> 
                                      <th>gender</th>
                                    <th>actions</th>
                                  </tr>
                                </thead>
                                <tbody>
                                  <tr data-ng-repeat="d in vm.studentAdmissions">
                                    <td>{{d.studentAdmission_id}}</td>
                                    <td>{{d.full_name}}</td>
                                    <td>{{d.registration_no}}</td>
                                    <td data-ng-init="d.date_of_birth=vm.formatDate(d.date_of_birth)">{{d.date_of_birth| date:"dd-MMM-yyyy"}}</td>
                                    <td data-ng-init="d.admission_date=vm.formatDate(d.admission_date)">{{d.admission_date| date:"dd-MMM-yyyy"}}</td>
                                    <td>{{d.class_name}}</td>
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
            <script src="studentAdmission.js"></script>
          </div>
</asp:Content>

