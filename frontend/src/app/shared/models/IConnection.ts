
export interface IConnection {
    id: number,
    connectionType: number,
    connectionDetails: IConnectionDetails[],
    contractNumber: string,
    contractWith: string,
    interface: string
}
export interface IConnectionDetails {
    key: string,
    value: string
}