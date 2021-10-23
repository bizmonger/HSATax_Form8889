namespace HSATaxForm_2020

open System

module rec Language =

    module InEligible =

        type Coverage = Medicare | TriCare | TriCareLife

    type Amount                   = float
    type IsSelfEmployed           = bool
    type IsEmployeesFiftyOrFewer  = bool
    type NoOtherCoverageCompliant = bool
    type HadSameCoverage          = bool
    type Plans                    = string seq
    type AdditionalPercentageTax  = float

    type IsDead          = bool
    type IsDisabled      = bool
    type Turned65        = bool

    module Contributions =

        module AdditionalAmount =

            type Conditions = {
                IsFiftyFivePlus : bool
                IsMarried       : bool
                FamilyCoverageBySelfOrSpouse : bool
            }

        type Applicable = Amount
        module InExcess = type WithdrawnByDueDate = Amount

    module ThisYear =

        module Self =

            module Contributions =

                type Applicable = Amount

    module TaxYear =

        type MonthsCovered = int

        module EndOf = type IsUnder55     = bool
        module Self  = type Contributions = float

    module HDHP =

        type Plan     = string
        type IsSelf   = bool
        type IsSpouse = bool

    module MSA = 

        module Self     = type Contribution              = Amount
        module Employer = type Contribution              = Amount
        module Family   = type TowardsSpouseContribution = Amount

    module HSA =

        type Account = { Name : string }

        type Distribution  = { 
            Account   : Account
            Amount    : float 
            Timestamp : DateTime
          }

        type Distributions = Distribution seq

        type RollOver = { 
            Distribution : Distribution
            Target       : Account
        }
        
        type ExceptionsToPercentageTax = {
            IsDead     : bool
            IsDisabled : bool
            Turned65   : bool
        }

        type RollOvers = RollOver seq

        type HDHPCoverage  = SelfOnly | Family
        type QualifiedFundingDistributions = Amount
        type EmployerContributions         = Amount
        type MedicalExpensesPaidByDistribution  = { Distribution : Distribution }
        type MedicalExpensesPaidByDistributions = MedicalExpensesPaidByDistribution seq

        type ContributionLimit = Amount