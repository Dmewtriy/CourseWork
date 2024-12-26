using CourseWork1.DTOs;
using System;
using System.Collections.Generic;

namespace CourseWork1.Views
{
    public interface ICompanyRepresentativesView
    {
        event EventHandler<CompanyRepresentativeDTO> CompanyRepresentativeAdded;
        event EventHandler<CompanyRepresentativeDTO> CompanyRepresentativeUpdated;
        event EventHandler<CompanyRepresentativeDTO> CompanyRepresentativeDeleted;
        event EventHandler LoadCompanyRepresentativesRequested;
        event EventHandler<long> CompanyRepresentativeSearchRequested;
        void ShowErrorMessage(string message);
        void UpdateCompanyRepresentativesList(IEnumerable<CompanyRepresentativeDTO> CompanyRepresentatives);
        void HighlightCompanyRepresentative(CompanyRepresentativeDTO CompanyRepresentative);
    }
}
