export interface IIsp {
    name: string,
    contractNumber: string,
    contractWith: string,
    ispContacts: IIspContacts[],
    description: string
}

export interface IIspContacts{
    communicationType: number,
    value: string,
    description: string
}