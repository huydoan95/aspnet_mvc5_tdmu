/**
 * @license Copyright (c) 2003-2015, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see LICENSE.md or http://ckeditor.com/license
 */

CKEDITOR.editorConfig = function( config ) {
	// Define changes to default configuration here. For example:
	// config.language = 'fr';
    // config.uiColor = '#AADC6E';
    config.language = 'vi';
    config.filebrowserBrowseUrl = '/Content/Admin/ckfinder/ckfinder.html';
    config.filebrowserImageBrowseUrl = '/Content/Admin/ckfinder.html?Type=Images';
    config.filebrowserFlashBrowseUrl = '/Content/Admin/ckfinder.html?Type=Flash';
    config.filebrowserUploadUrl = '/Content/Admin/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files';
    config.filebrowserImageUploadUrl = '/Content/Client/';
    config.filebrowserFlashUploadUrl = '/Content/Admin/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash';
    CKFinder.setupCKEditor(null, '/Content/Admin/ckfinder/');
};
