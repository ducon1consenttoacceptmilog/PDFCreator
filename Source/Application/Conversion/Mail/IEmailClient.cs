﻿namespace pdfforge.PDFCreator.Conversion.Mail
{
    public interface IEmailClient
    {
        bool IsClientInstalled { get; }
        bool ShowEmailClient(Email email);
    }
}