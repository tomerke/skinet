export interface IPagination {
    id: number;
    name: string;
    description: string;
    price: number;
    pictureUrl: string;
    procutType: string;
    productBrand: string;
}

export interface IPagination {
    pageIndex: number;
    pageSize: number;
    count: number;
    data: Datum[];
}