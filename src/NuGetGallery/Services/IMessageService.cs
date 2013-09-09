using System.Net.Mail;

namespace NuGetGallery
{
  public interface IMessageService
  {
    void SendContactOwnersMessage(MailAddress fromAddress, PackageRegistration packageRegistration, string message, string emailSettingsUrl);
    void ReportAbuse(ReportPackageRequest report);
    void ReportMyPackage(ReportPackageRequest report);
    void SendNewAccountEmail(MailAddress toAddress, string confirmationUrl);
    void SendEmailChangeConfirmationNotice(MailAddress newEmailAddress, string confirmationUrl);
    void SendPasswordResetInstructions(User user, string resetPasswordUrl);
    void SendEmailChangeNoticeToPreviousEmailAddress(User user, string oldEmailAddress);
    void SendPackageOwnerRequest(User fromUser, User toUser, PackageRegistration package, string confirmationUrl);
    void SendNewAdminApprovedAccountEmail(MailAddress toAddress, string username, string userEmail, string confirmationUrl);
    void SendAdminApprovedAccountVerifiedEmail(MailAddress toAddress, string username);
  }
}