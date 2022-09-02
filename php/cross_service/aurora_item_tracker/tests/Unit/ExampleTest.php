<?php

namespace Tests\Unit;

use App\Models\Item;
use Tests\TestCase;

class ExampleTest extends TestCase
{
    protected Item $item;

    public function test_it_gets_items_by_state()
    {
        $item = new Item();
        $this->assertJson($item->getItemsByState());
        $this->assertJson($item->getItemsByState('active'));
        $this->assertJson($item->getItemsByState('archive'));
        $this->assertJson($item->getItemsByState('all'));
    }
}
