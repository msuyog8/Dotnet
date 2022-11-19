namespace Patientlib;

class InhousePatient : Patient
{

    

    InhousePatient(int dd, int cc): base(int dd, int cc)
    {

        
    }

public override double  getBillAmount(int days , int bed)
{

    return days * getPricePerDay(bed) * 0.95;
}
}