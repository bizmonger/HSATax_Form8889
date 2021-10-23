namespace HSATaxForm_2020

open Language

module Part3 =

    module Line =

        type Eighteen   = HSA.ContributionLimit -> TaxYear.MonthsCovered -> Amount
        type Nineteen   = Part1.Line.Ten
        type Tweenty    = Eighteen -> Nineteen -> Amount
        type TweentyOne = Tweenty -> AdditionalPercentageTax -> Amount