(function () {
    "use strict";

    app.controller("sectionCtrl", function ($http) {

        var vm = this;
        vm.title = "Section";
        vm.entry_form = false;
        vm.sections = [];
        vm.Classes = [];
        vm.Teachers = [];

        vm.objSection = {};
        getList();
        vm.retData = {};
        vm.btnSave = true;
        vm.btnUpdate = false;
        vm.btnRefresh = true;


        vm.view = viewData;
        vm.Save = save;
        vm.Put = update;
        vm.Refresh = refreshForm;


        function refreshForm() {
            vm.objSection = null;
            vm.cmbTeachers = null;
            vm.cmbClasses = null;
            vm.btnSave = true;
            vm.btnUpdate = false;
            vm.entry_form = false;
            getList();
        }

        function viewData(dataItem) {
            vm.objSection = dataItem;
            vm.cmbTeachers = { teacher_id: vm.objSection.teacher_id };
            vm.cmbClasses = { class_id: vm.objSection.class_id };
            vm.btnSave = false;
            vm.btnUpdate = true;
            vm.entry_form = true;

        }
        function save() {

            vm.httpreq = {
                method: 'POST',
                url: 'Section.aspx/Save',
                headers: {
                    'Content-Type': 'application/json; charset=utf-8',
                    'dataType': 'json'
                },
                data: { _section: vm.objSection }
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
                url: 'Section.aspx/Put',
                headers: {
                    'Content-Type': 'application/json; charset=utf-8',
                    'dataType': 'json'
                },
                data: { _section: vm.objSection }
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
                url: 'Section.aspx/Get',
                headers: {
                    'Content-Type': 'application/json; charset=utf-8',
                    'dataType': 'json'
                },
                data: {}
            }
            $http(vm.httpreq).success(function (data, status, headers, config) {
                // alert(data.d);
                var ds = JSON.parse(data.d);
                vm.sections = ds.SectionList;
                vm.Classes = ds.ClassList;
                vm.Teachers = ds.TeacherList;

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