(function () {
    "use strict";

    app.controller("occupationCtrl", function ($http) {

        var vm = this;
        vm.title = "Occupation";
        vm.entry_form = false;
        vm.occupations = [];

        vm.objOccupation = {};
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
            vm.objOccupation = null;
            vm.btnSave = true;
            vm.btnUpdate = false;
            vm.entry_form = false;
            getList();
        }

        function viewData(dataItem) {
            vm.objOccupation = dataItem;
            vm.btnSave = false;
            vm.btnUpdate = true;
            vm.entry_form = true;

        }
        function save() {

            vm.httpreq = {
                method: 'POST',
                url: 'Occupation.aspx/Save',
                headers: {
                    'Content-Type': 'application/json; charset=utf-8',
                    'dataType': 'json'
                },
                data: { _occupation: vm.objOccupation }
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
                url: 'Occupation.aspx/Put',
                headers: {
                    'Content-Type': 'application/json; charset=utf-8',
                    'dataType': 'json'
                },
                data: { _occupation: vm.objOccupation }
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
                url: 'Occupation.aspx/Get',
                headers: {
                    'Content-Type': 'application/json; charset=utf-8',
                    'dataType': 'json'
                },
                data: {}
            }
            $http(vm.httpreq).success(function (data, status, headers, config) {
                // alert(data.d);
                var ds = JSON.parse(data.d);
                vm.occupations = ds.OccupationList;
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