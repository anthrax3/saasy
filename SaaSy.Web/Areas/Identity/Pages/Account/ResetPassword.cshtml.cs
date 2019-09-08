﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SaaSy.Entity.Identity;
using SaaSy.Web.Resources.Areas.Identity.Pages.Account;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SaaSy.Web.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ResetPasswordModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ResetPasswordModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email", ResourceType = typeof(ResetPassword))]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessageResourceName = "PasswordInvalid", MinimumLength = 6, ErrorMessageResourceType = typeof(ResetPassword))]
            [DataType(DataType.Password)]
            [Display(Name = "Password", ResourceType = typeof(ResetPassword))]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "ConfirmPassword",ResourceType = typeof(ResetPassword))]
            [Compare("Password", ErrorMessageResourceName = "ConfirmPasswordInvalid", ErrorMessageResourceType = typeof(ResetPassword))]
            public string ConfirmPassword { get; set; }

            public string Code { get; set; }
        }

        public IActionResult OnGet(string code = null)
        {
            if (code == null)
            {
                return BadRequest(ResetPassword.CodeMustBeSupplied);
            }
            else
            {
                Input = new InputModel
                {
                    Code = code
                };
                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.FindByEmailAsync(Input.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToPage("./ResetPasswordConfirmation");
            }

            var result = await _userManager.ResetPasswordAsync(user, Input.Code, Input.Password);
            if (result.Succeeded)
            {
                return RedirectToPage("./ResetPasswordConfirmation");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return Page();
        }
    }
}
