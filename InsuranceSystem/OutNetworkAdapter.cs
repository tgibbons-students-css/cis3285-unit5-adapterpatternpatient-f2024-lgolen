namespace Unit5_AdapterPatternPatient_Blazor.InsuranceSystem
{
    public class OutNetworkAdapter : InsuranceInterface
    {
        OutNetworkPatient patient;
        public OutNetworkAdapter(string newName, int newPolicyNumber) {
            patient = new OutNetworkPatient(newName, newPolicyNumber);
        }
        public bool IsCovered(string patientName, string policyNumber)
        {
            string covered = patient.IsCovered(patientName, int.Parse(policyNumber));

            if (covered == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public decimal CoverageAmount(int ProcedureID, decimal ProcedureCost)
        {
            decimal coveragePercent = patient.CoveragePercent(ProcedureCost);
            return (coveragePercent * ProcedureCost);
        }
        public string getPatientName()
        {
            return patient.getPatientName();
        }

        public string getPolicyNumber()
        {
            return patient.PolicyNumber.ToString();
        }
    }
}