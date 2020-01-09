
$(document).ready(function () {
  $('#form1').bootstrapValidator({
    message: 'This value is not valid',
    feedbackIcons: {
      valid: 'glyphicon glyphicon-ok',
      invalid: 'glyphicon glyphicon-remove',
      validating: 'glyphicon glyphicon-refresh'
    },
    fields: {
      txtFirstname_YS: {
        message: 'First name is not valid',
        validators: {
          notEmpty: {
            message: 'First name is required'
          },
          //stringLength: {
          //  min: 6,
          //  max: 30,
          //  message: 'First name must be more than 6 and less than 30 characters long'
          //},
          regexp: {
            regexp: /^[a-zA-Z0-9_]+$/,
            message: 'First name in use only alphabetical, number and underscore'
          }
        }
      },
      txtEmail_YS: {
        validators: {
          notEmpty: {
            message: 'Email is required'
          },
          emailAddress: {
            message: 'Email address is not a valid'
          }
        }
      },
      txtLastname_YS: {
        message: 'Lastname is not valid',
        validators: {
          notEmpty: {
            message: 'Lastname is required'
          },
          //stringLength: {
          //  min: 6,
          //  max: 30,
          //  message: 'The lastname must be more than 6 and less than 30 characters long'
          //},
          regexp: {
            regexp: /^[a-zA-Z0-9_]+$/,
            message: 'Last name in use only alphabetical, number and underscore'
          }
        }
      },
      txtMobileno_YS: {
        message: 'Mobile no is not valid',
        validators: {
          notEmpty: {
            message: 'Mobile no is required'
          },
          //stringLength: {
          //  min: 6,
          //  max: 30,
          //  message: 'The lastname must be more than 6 and less than 30 characters long'
          //},
          regexp: {
            regexp: /(^[0-9_]{10})+$/,
            message: 'Mobile no in use only number or 10 digit'
          }
        }
      },
    }
  });
});

