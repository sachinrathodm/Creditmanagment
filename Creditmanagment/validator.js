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
      txtPassword_YS: {
        message: 'Password is not valid',
        validators: {
          notEmpty: {
            message: 'Password is required'
          },
          stringLength: {
            min: 6,
            max: 10,
            message: 'Password must be more than 6 and less than 10 characters long'
          },
          regexp: {
            regexp: /^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^\w\s]).{6,10}$/,
            message: 'Password in 1 number, 1 lowarcase, 1 upparcase, 1 special character is required'
          }
        }
      },
      txtRetypepassword_YS: {
        message: 'Password is not valid',
        validators: {
          notEmpty: {
            message: 'Password is required'
          },
          stringLength: {
            min: 6,
            max: 10,
            message: 'Password must be more than 6 and less than 10 characters long'
          },
          regexp: {
            regexp: /^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^\w\s]).{6,10}$/,
            message: 'Password in 1 number, 1 lowarcase, 1 upparcase, 1 special character is required'
          }
        }
      },
      txtConfirmPassword_YS: {
        message: 'Password is not valid',
        validators: {
          notEmpty: {
            message: 'Password is required'
          },
          stringLength: {
            min: 6,
            max: 10,
            message: 'Password must be more than 6 and less than 10 characters long'
          },
          regexp: {
            regexp: /^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^\w\s]).{6,10}$/,
            message: 'Password in 1 number, 1 lowarcase, 1 upparcase, 1 special character is required'
          }
        }
      },
      txtAddress_YS: {
        message: 'Address is not valid',
        validators: {
          notEmpty: {
            message: 'Address is required'
          },
          regexp: {
            regexp: /^[#.0-9a-zA-Z\s,-]+$/,
            message: 'Address in use only characters, numbers, # and - is required'
          }
        }
      },
      txtStorename_YS: {
        message: 'Store name is not valid',
        validators: {
          notEmpty: {
            message: 'Store name is required'
          },
          //stringLength: {
          //  min: 6,
          //  max: 30,
          //  message: 'First name must be more than 6 and less than 30 characters long'
          //},
          regexp: {
            regexp: /^[a-z\sA-Z]+$/,
            message: 'Store name in use only alphabetical'
          }
        }
      },
      txtStorecategory_YS: {
        message: 'Store category is not valid',
        validators: {
          notEmpty: {
            message: 'Store category is required'
          },
          //stringLength: {
          //  min: 6,
          //  max: 30,
          //  message: 'First name must be more than 6 and less than 30 characters long'
          //},
          regexp: {
            regexp: /^[a-z\sA-Z]+$/,
            message: 'Store category in use only alphabetical'
          }
        }
      },
      txtHelplineno_YS: {
        message: 'Helpline no is not valid',
        validators: {
          notEmpty: {
            message: 'Helpline no is required'
          },
          //stringLength: {
          //  min: 6,
          //  max: 30,
          //  message: 'The lastname must be more than 6 and less than 30 characters long'
          //},
          regexp: {
            regexp: /(^[0-9_]{13})+$/,
            message: 'Helpline no in use only number or 10 digit'
          }
        }
      },
      txtAdharcardno_YS: {
        message: 'Adharcard no is not valid',
        validators: {
          notEmpty: {
            message: 'Adharcard no is required'
          },
          //stringLength: {
          //  min: 12,
          //  max: 12,
          //  message: 'Adharcard no only 12 digit'
          //},
          regexp: {
            regexp: /^(\d{12})$/,
            message: 'Adharcard no in use only number and only 12 digits'
          }
        }
      },
      txtItemname_YS: {
        message: 'Item name no is not valid',
        validators: {
          notEmpty: {
            message: 'Item name no is required'
          },
        }
      },
      txtRate_YS: {
        message: 'Rate no is not valid',
        validators: {
          notEmpty: {
            message: 'Rate no is required'
          },
        }
      },
    }
  });
});
