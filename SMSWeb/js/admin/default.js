$(document).ready(function() {
	$('[data-toggle="offcanvas"]').click(function() {
		$('#side-menu').toggleClass('hidden-xs');
	});

	$('[data-toggle="toggleForm"]').click(function () {
	    $('[data-toggle="toggleForm"]').text($('[data-toggle="toggleForm"]').text() == 'Data List' ? 'Create new' : 'Data List');
	    $('#entry-form').toggleClass('hidden');
	});
});