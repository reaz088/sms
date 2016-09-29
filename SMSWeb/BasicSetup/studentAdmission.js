(function () {
    "use strict";

    app.controller("studentAdmissionCtrl", function ($http) {

        var vm = this;
        vm.title = "StudentAdmission";
        vm.entry_form = false;
        vm.studentAdmissions = [];
        vm.Classes =[];
        vm.SessionYears = [];
        vm.Districts = [];

        vm.objStudentAdmission = {};
        getList();
        vm.retData = {};
        vm.btnSave = true;
        vm.btnUpdate = false;
        vm.btnRefresh = true;


        vm.view = viewData;
        vm.Save = save;
        vm.Put = update;
        vm.Refresh = refreshForm;
        vm.formatDate = formatDate;



        function formatDate(date) {
            var dateOut = new Date(date);
            return dateOut;
        };

        function refreshForm() {
            vm.objStudentAdmission = null;
            vm.cmbClasses = null;

            vm.btnSave = true;
            vm.btnUpdate = false;
            vm.entry_form = false;
            getList();
        }

        function viewData(dataItem) {
            vm.objStudentAdmission = dataItem;
            vm.cmbClasses = { class_id: vm.objStudentAdmission.class_id };
            vm.cmbSessionYears = { session_id: vm.objStudentAdmission.academic_year_id };
            vm.cmbDistricts = { district_id: vm.objStudentAdmission.district_id };
            vm.btnSave = false;
            vm.btnUpdate = true;
            vm.entry_form = true;

        }
        function save() {

            vm.httpreq = {
                method: 'POST',
                url: 'StudentAdmission.aspx/Save',
                headers: {
                    'Content-Type': 'application/json; charset=utf-8',
                    'dataType': 'json'
                },
                data: { _studentAdmission: vm.objStudentAdmission }
            }
            $http(vm.httpreq).success(function (response) {
                vm.retData = response.d;
                getList();
                //alert("Saved successfully.");
            });
        };
        function update() {

            vm.httpreq = {
                method: 'POST',
                url: 'StudentAdmission.aspx/Put',
                headers: {
                    'Content-Type': 'application/json; charset=utf-8',
                    'dataType': 'json'
                },
                data: { _studentAdmission: vm.objStudentAdmission }
            }
            $http(vm.httpreq).success(function (response) {
                vm.retData = response.d;
                getList();
                //alert("Saved successfully.");
            });
        };
        function getList() {

            vm.httpreq = {
                method: 'POST',
                url: 'StudentAdmission.aspx/Get',
                headers: {
                    'Content-Type': 'application/json; charset=utf-8',
                    'dataType': 'json'
                },
                data: {}
            }
            $http(vm.httpreq).success(function (data, status, headers, config) {
                // alert(data.d);
                var ds = JSON.parse(data.d);
                vm.studentAdmissions = ds.StudentAdmissionList;
                vm.Classes = ds.ClasseList;
                vm.SessionYears = ds.SessionYearList;
                vm.Districts = ds.DistrictList;

            })
                   .error(function (data, status, headers, config) {
                       var _status = status;
                   });
        };




        //function getList() {

        //    vm.httpreq = {
        //        method: 'POST',
        //        url: 'Class.aspx/Get',
        //        headers: {
        //            'Content-Type': 'application/json; charset=utf-8',
        //            'dataType': 'json'
        //        },
        //        data: { }
        //    }
        //    $http(vm.httpreq).success(function(response) {
        //        vm.classes = response.d;
        //        // alert("Saved successfully.");
        //    });
        //};


    });
}());