(function () {
    "use strict";

    app.controller("groupCtrl", function ($http) {

        var vm = this;
        vm.title = "Group";
        vm.entry_form = false;
        vm.groups = [];
        vm.objGroup = {};
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
            vm.objGroup = null;
            vm.btnSave = true;
            vm.btnUpdate = false;
            vm.entry_form = false;
            getList();
        }

        function viewData(dataItem) {
            vm.objGroup = dataItem;
            vm.btnSave = false;
            vm.btnUpdate = true;
            vm.entry_form = true;

        }
        function save() {

            vm.httpreq = {
                method: 'POST',
                url: 'Group.aspx/Save',
                headers: {
                    'Content-Type': 'application/json; charset=utf-8',
                    'dataType': 'json'
                },
                data: { _group: vm.objGroup }
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
                url: 'Group.aspx/Put',
                headers: {
                    'Content-Type': 'application/json; charset=utf-8',
                    'dataType': 'json'
                },
                data: { _group: vm.objGroup }
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
                url: 'Group.aspx/Get',
                headers: {
                    'Content-Type': 'application/json; charset=utf-8',
                    'dataType': 'json'
                },
                data: {}
            }
            $http(vm.httpreq).success(function (data, status, headers, config) {
                // alert(data.d);
                var ds = JSON.parse(data.d);
                vm.groups = ds.GroupList;
            })
                   .error(function (data, status, headers, config) {
                       var _status = status;
                   });
        };




        //function getList() {

        //    vm.httpreq = {
        //        method: 'POST',
        //        url: 'Group.aspx/Get',
        //        headers: {
        //            'Content-Type': 'application/json; charset=utf-8',
        //            'dataType': 'json'
        //        },
        //        data: { }
        //    }
        //    $http(vm.httpreq).success(function(response) {
        //        vm.groupes = response.d;
        //        // alert("Saved successfully.");
        //    });
        //};


    });
}());