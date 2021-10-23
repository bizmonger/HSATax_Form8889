namespace HSATaxForm_2020.Shared

open HSATaxForm_2020.Language

module Operations =

    module Calculate =

        type LesserOf = float -> float -> float

    module Eligibility =

        type HasFirstDayEveryMonth = HDHP.Plan -> bool
        type IsMSAQualified        = IsSelfEmployed -> IsEmployeesFiftyOrFewer -> bool

    module HDHP =

        module Family =

            module Spouse =

                type SeparateHSA = bool

            type BySelfOrSpouse = HDHP.IsSelf -> HDHP.IsSpouse -> bool