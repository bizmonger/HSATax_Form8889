namespace HSATaxForm_2020

open Language
open Language.HSA

module Part2 =

    module Line =

        type Fourteen_A  = Distributions -> Amount
        type Fourteen_B  = Distributions -> RollOvers -> Contributions.InExcess.WithdrawnByDueDate -> Amount
        type Fourteen_C  = Fourteen_B -> Fourteen_A -> Amount
        type Fifteen     = MedicalExpensesPaidByDistributions -> Amount
        type Sixteen     = Fourteen_C -> Fifteen -> Amount

        type Seventeen_A = ExceptionsToPercentageTax -> bool
        type Seventeen_B = Distributions -> AdditionalPercentageTax -> Amount