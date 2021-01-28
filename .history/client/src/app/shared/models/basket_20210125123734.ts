declare module namespace {

    export interface Item {
        id: number;
        productName: string;
        price: number;
        quantity: number;
        pictureUrl: string;
        brand: string;
        type: string;
    }

    export interface RootObject {
        id: string;
        items: Item[];
    }

}