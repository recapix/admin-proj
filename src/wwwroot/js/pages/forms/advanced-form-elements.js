$(function () {

  //Dropzone
  Dropzone.options.frmFileUpload = {
    paramName: "file",
    maxFilesize: 2
  };

  //Masked Input ============================================================================================================================
  var $demoMaskedInput = $('.demo-masked-input');

  //Date
  $demoMaskedInput.find('.date').inputmask('dd/mm/yyyy', { placeholder: '__/__/____' });

  
  //CPF
  $demoMaskedInput.find('.cpf').inputmask('999.999.999-99', { placeholder: '___.___.___-__' });

  //RG
  $demoMaskedInput.find('.rg').inputmask('99.999.999-9', { placeholder: '__.___.___-_' });


});
