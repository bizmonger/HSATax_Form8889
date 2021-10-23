namespace HSATaxForm_2020

open Language
open Language.HSA

open HSATaxForm_2020.Shared.Operations

module Part1 =

    module Line =

        type One      = HDHPCoverage
        type Two      = TaxYear.Self.Contributions -> ThisYear.Self.Contributions.Applicable -> Amount
        type Three    = TaxYear.EndOf.IsUnder55    -> Eligibility.HasFirstDayEveryMonth -> NoOtherCoverageCompliant -> HadSameCoverage -> Amount
        type Four     = MSA.Self.Contribution -> MSA.Employer.Contribution -> HDHP.Family.BySelfOrSpouse -> MSA.Family.TowardsSpouseContribution -> Amount
        type Five     = Four -> Three -> Amount
        type Six      = Five -> HDHP.Family.Spouse.SeparateHSA -> Amount
        type Seven    = Contributions.AdditionalAmount.Conditions -> Amount -> Amount
        type Eight    = Six -> Seven -> Amount
        type Nine     = EmployerContributions
        type Ten      = QualifiedFundingDistributions
        type Eleven   = Nine   -> Ten   -> Amount
        type Twelve   = Eleven -> Eight -> Amount
        type Thirteen = Two -> Twelve -> Calculate.LesserOf -> Amount