
export interface IConnection {
    id: number,
    type: number,
    connectionDetails: IConnectionDetails[],
    contractNumber: string,
    contractWith: string,
    interface: string,
    ispId: number
}
export interface IConnectionDetails {
    key: string,
    value: string
}