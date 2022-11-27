using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPlayground.Persistence.Entities
{
    [Table("users")]
    public class User : IdentityUser<int>
    {
        [Column("id")]
        public override int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("mobile_phone")]
        public string MobilePhone { get; set; }

        [Column("role_id")]
        public int RoleId { get; set; }

        [Column("is_enabled")]
        public bool IsEnabled { get; set; }

        [Column("access_token")]
        public string AccessToken { get; set; }

        [Column("geofence_id_list")]
        public int[] GeofenceIds { get; set; }

        [Column("controlcenter_login")]
        public bool IsClientUser { get; set; }

        [Column("email")]
        public override string Email { get; set; }

        [Column("otp_token")]
        public string OneTimePassword { get; set; }

        [Column("phone_number")]
        public override string PhoneNumber { get; set; }

        [Column("user_name")]
        public override string UserName { get; set; }

        [Column("normalized_user_name")]
        public override string NormalizedUserName { get; set; }

        [Column("normalized_email")]
        public override string NormalizedEmail { get; set; }

        [Column("email_confirmed")]
        public override bool EmailConfirmed { get; set; }

        [Column("password_hash")]
        public override string PasswordHash { get; set; }

        [Column("security_stamp")]
        public override string SecurityStamp { get; set; }

        [Column("concurrency_stamp")]
        public override string ConcurrencyStamp { get; set; }

        [Column("phone_number_confirmed")]
        public override bool PhoneNumberConfirmed { get; set; }

        [Column("two_factor_enabled")]
        public override bool TwoFactorEnabled { get; set; }

        [Column("lockout_end")]
        public override DateTimeOffset? LockoutEnd { get; set; }

        [Column("lockout_enabled")]
        public override bool LockoutEnabled { get; set; }

        [Column("access_failed_count")]
        public override int AccessFailedCount { get; set; }

        [Column("last_signed_in_at")]
        public DateTime? LastSignedInAt { get; set; }
    }
}
