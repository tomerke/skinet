export interface Datum {
    id: number;
    name: string;
    description: string;
    price: number;
    pictureUrl: string;
    procutType: string;
    productBrand: string;
}

export interface RootObject {
    pageIndex: number;
    pageSize: number;
    count: number;
    data: Datum[];
}